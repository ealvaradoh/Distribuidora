using Distribuidora.BL.BL;
using Distribuidora.BL.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Win
{
    public partial class frm_ordenes : Form
    {
        public ordenesBL _ordenesBL;
        public productosBL _productosBL;
        public proveedoresBL _proveedoresBL;
        bool esNuevo;
        public frm_ordenes()
        {
            _ordenesBL = new ordenesBL();
            _productosBL = new productosBL();
            _proveedoresBL = new proveedoresBL();
            
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            listaOrdenesBindingSource.DataSource = _ordenesBL.ObtenerOrdenes();
            listaProveedoresBindingSource.DataSource = _proveedoresBL.ObtenerProveedores();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }

        public void Permisos(bool departamentoControlTotal)
        {
            if (departamentoControlTotal == true)
            {
                bindingNavigator.Enabled = true;
            }
            else if (departamentoControlTotal == false)
            {
                bindingNavigator.Enabled = false;
            }
        }

        public void EstadoBotones(bool estado)
        {
            bindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
            panelDetalle.Enabled = !estado;
        }   

        private void orden_detalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var ordenGuardada = (orden_entrega)listaOrdenesBindingSource.Current;
                var resultado = _ordenesBL.GuardarOrden(ordenGuardada);
                if (resultado.Exitoso == true)
                {
                    listaOrdenesBindingSource.RemoveCurrent();

                    listaOrdenesBindingSource.ResetBindings(false);
                    EstadoBotones(true);
                    bindingNavigatorSaveItem.Enabled = false;
                }
                else
                    MessageBox.Show(resultado.Mensaje);
                
            }
            else if (esNuevo == false)
            {
                var ordenEditado = (orden_entrega)listaOrdenesBindingSource.Current;
                _ordenesBL.EditarOrden(ordenEditado);

                listaOrdenesBindingSource.ResetBindings(false);
                EstadoBotones(true);
                bindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _ordenesBL.AgregarOrden();
            listaOrdenesBindingSource.MoveLast();
            EstadoBotones(false);
            bindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            bindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var ordenCancelada = (orden_entrega)listaOrdenesBindingSource.Current;
                _ordenesBL.CancelarOrden(ordenCancelada);
                EstadoBotones(true);
                bindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                listaOrdenesBindingSource.CancelEdit();
                orden_detalleBindingSource.CancelEdit();
                EstadoBotones(true);
                bindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void ListaProductosDetalleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var orden = (orden_entrega)listaOrdenesBindingSource.Current;
                _ordenesBL.AgregarOrdenDetalle(orden);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void ListaProductosDetalleDelete_Click(object sender, EventArgs e)
        {
            var orden = (orden_entrega)listaOrdenesBindingSource.Current;
            var ordenDetalle = (orden_detalle)orden_detalleBindingSource.Current;

            _ordenesBL.RemoverOrdenDetalle(orden, ordenDetalle);
        }

        private void orden_detalleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var orden = (orden_entrega)listaOrdenesBindingSource.Current;
            orden.CalcularTotalCantidad();
            listaOrdenesBindingSource.ResetBindings(false);
        }
    }
}
