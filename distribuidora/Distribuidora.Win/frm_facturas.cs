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
            listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
            listaNombreCajerosBindingSource.DataSource = _cajerosBL.ObtenerNombreCajeros();
        }

        public void LimpiarDatos()
        {
            listaFacturasBindingSource.Clear();
            listaClientesBindingSource.Clear();
            listaProductosBindingSource.Clear();
            listaNombreCajerosBindingSource.Clear();
        }

        public void RecargarDatos()
        {
            int posicion = listaFacturasBindingSource.Position;
            LimpiarDatos();
            CargarDatos();
            listaFacturasBindingSource.ResetBindings(true);
            listaFacturasBindingSource.Position = posicion;
            EstadoBotones(true);
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

        public void Permisos()
        {
            bindingNavigatorDelete.Enabled = 
                resultadoLogin.departamentoControlTotal;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            var resultado = _facturasBL.AgregarFactura();
            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.MoveLast();
                EstadoBotones(false);
                this.tabControl1.SelectedTab = tabPage2;
            }
            else
                MessageBox.Show(resultado.Mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                RecargarDatos();
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
                    RecargarDatos();
                    MessageBox.Show(resultado.Mensaje, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(resultado.Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (esNuevo == false)
            {
                var facturaEditada = (factura)listaFacturasBindingSource.Current;
                var resultado = _facturasBL.EditarFactura(facturaEditada);
                if (resultado.Exitoso == true)
                {
                    RecargarDatos();
                    MessageBox.Show(resultado.Mensaje, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(resultado.Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                this.tabControl1.SelectedTab = tabPage2;
            }
            else
                MessageBox.Show(resultado.Mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ListaFacturaDetalleDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            var facturaEliminada = (factura)listaFacturasBindingSource.Current;
            _facturasBL.EliminarFactura(facturaEliminada);
            RecargarDatos();
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

        private void factura_detalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void listaFacturasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e)
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            _facturasBL.AgregarFacturaDetalle(factura);
            factura_detalleDataGridView.Focus();
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            var factura_detalle = (factura_detalle)factura_detalleBindingSource.Current;

            _facturasBL.RemoverFacturaDetalle(factura, factura_detalle);
            CalcularTotales();
        }

        private void fact_subtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fact_subtTextBox.Text = String.Format("{0:N2}", decimal.Parse(fact_subtTextBox.Text));
            }
            catch (Exception)
            {
            }
        }

        private void fact_isvTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fact_isvTextBox.Text = String.Format("{0:N2}", decimal.Parse(fact_isvTextBox.Text));
            }
            catch (Exception)
            {
            }
        }

        private void fact_totalTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fact_totalTextBox.Text = String.Format("{0:N2}", decimal.Parse(fact_totalTextBox.Text));
            }
            catch (Exception)
            {
            }
        }
    }
}
