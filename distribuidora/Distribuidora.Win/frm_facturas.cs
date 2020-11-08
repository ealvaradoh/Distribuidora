using Distribuidora.BL.BL;
using Distribuidora.BL.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Win
{
    public partial class frm_facturas : Form
    {
        facturasBL _facturasBL;
        clientesBL _clientesBL;
        cajerosBL _cajerosBL;
        productosBL _productosBL;
        bool esNuevo;
        public frm_facturas()
        {
            _facturasBL = new facturasBL();
            _clientesBL = new clientesBL();
            _cajerosBL = new cajerosBL();
            _productosBL = new productosBL();

            InitializeComponent();
            CargarDatos();
            
            Permisos();
        }

        public void CargarDatos()
        {
            Application.DoEvents();
            listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
            listaNombreCajerosBindingSource.DataSource = _cajerosBL.ObtenerNombreCajeros();
        }

        public void Permisos()
        {
            if (resultadoLogin.departamentoControlTotal == true)
            {
                bindingNavigatorDelete.Enabled = true;
            }
            else if (resultadoLogin.departamentoControlTotal == false)
            {
                bindingNavigatorDelete.Enabled = false;
            }
        }

        public void EstadoBotones(bool estado)
        {
            BindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
            panelDetalle.Enabled = !estado;
            bindingNavigatorSaveItem.Enabled = !estado;
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            var factura = (factura)listaFacturasBindingSource.Current;

            var resultado = _facturasBL.AgregarFactura();
            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.MoveLast();
                EstadoBotones(false);
            }
            else
                MessageBox.Show(resultado.Mensaje, "Alerta");
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var facturacancelada = (factura)listaFacturasBindingSource.Current;
                _facturasBL.CancelarFactura(facturacancelada);
                EstadoBotones(true);
            }
            else if (esNuevo == false)
            {
                var facturacancelada = (factura)listaFacturasBindingSource.Current;
                listaFacturasBindingSource.Clear();
                listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();
                listaFacturasBindingSource.Position = facturacancelada.fact_id - 1;
                EstadoBotones(true);
            }
        }

        private void ListaFacturaDetalleAdd_Click(object sender, EventArgs e)
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            _facturasBL.AgregarFacturaDetalle(factura);
            factura_detalleDataGridView.Focus();
        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var facturaGuardada = (factura)listaFacturasBindingSource.Current;
                var resultado = _facturasBL.GuardarFactura(facturaGuardada);
                if (resultado.Exitoso == true)
                {
                    listaFacturasBindingSource.Clear();

                    listaFacturasBindingSource.ResetBindings(false);
                    listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();
                    listaFacturasBindingSource.MoveLast();
                    EstadoBotones(true);
                }
                else
                    MessageBox.Show(resultado.Mensaje, "Alerta");

            }
            else if (esNuevo == false)
            {
                var facturaEditada = (factura)listaFacturasBindingSource.Current;
                var resultado = _facturasBL.EditarFactura(facturaEditada);
                if (resultado.Exitoso == true)
                {
                    listaFacturasBindingSource.Clear();
                    listaFacturasBindingSource.ResetBindings(false);
                    listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();
                    listaFacturasBindingSource.Position = facturaEditada.fact_id - 1;
                    EstadoBotones(true);
                }
                else
                    MessageBox.Show(resultado.Mensaje, "Alerta");

            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            var resultado = _facturasBL.AutorizaCajeroAtiende(factura);
            if (resultado.Exitoso == true)
            {
                esNuevo = false;
                EstadoBotones(false);
            }
            else
                MessageBox.Show(resultado.Mensaje, "Alerta");
            
        }

        private void ListaFacturaDetalleDelete_Click(object sender, EventArgs e)
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (factura_detalle)factura_detalleBindingSource.Current;

            _facturasBL.RemoverFacturaDetalle(factura, facturaDetalle);
            CalcularTotales();
        }

        private void fact_subtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fact_subtTextBox.Text = String.Format("{0:N2}", decimal.Parse(fact_subtTextBox.Text));
            }
            catch (Exception error)
            {

            }

        }

        private void fact_isvTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fact_isvTextBox.Text = String.Format("{0:N2}", decimal.Parse(fact_isvTextBox.Text));
            }
            catch (Exception error)
            {

            }

        }

        private void fact_totalTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fact_totalTextBox.Text = String.Format("{0:N2}", decimal.Parse(fact_totalTextBox.Text));
            }
            catch (Exception error)
            {

            }
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {

        }

        public void CalcularTotales()
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            _facturasBL.CalcularTotalGeneral(factura);
            listaFacturasBindingSource.ResetBindings(true);
        }

        private void listaFacturasDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void factura_detalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }
    }
}
