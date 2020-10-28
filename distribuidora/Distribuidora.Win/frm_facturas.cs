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
            bindingNavigatorCancelItem.Enabled = false;
            CargarDatos();
        }

        public void CargarDatos()
        {
            listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
            listaNombreCajerosBindingSource.DataSource = _cajerosBL.ObtenerNombreCajeros();
        }

        /*public void Permisos()
        {
            if (frm_menu.departamentoID == 1)
            {
                ListaFacturaDetalleDelete.Enabled = true;
            }
            else if (frm_menu.departamentoID == 2)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }*/

        public void EstadoBotones(bool estado)
        {
            listaFacturasBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _facturasBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast();
            EstadoBotones(false);
            listaFacturasBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var facturacancelada = (factura)listaFacturasBindingSource.Current;
                _facturasBL.CancelarFactura(facturacancelada);
                EstadoBotones(true);
                listaFacturasBindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                EstadoBotones(true);
                listaFacturasBindingNavigatorSaveItem.Enabled = false;
                listaFacturasBindingSource.CancelEdit();
            }


        }

        private void ListaFacturaDetalleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var factura = (factura)listaFacturasBindingSource.Current;
                _facturasBL.AgregarFacturaDetalle(factura);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var facturaGuardada = (factura)listaClientesBindingSource.Current;
                _facturasBL.GuardarFactura();
                listaFacturasBindingSource.RemoveCurrent();

                listaClientesBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaFacturasBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            listaFacturasBindingNavigatorSaveItem.Enabled = true;
        }

        private void ListaFacturaDetalleDelete_Click(object sender, EventArgs e)
        {
            var factura = (factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (factura_detalle)factura_detalleBindingSource.Current;

            _facturasBL.RemoverFacturaDetalle(factura, facturaDetalle);
        }
    }
}
