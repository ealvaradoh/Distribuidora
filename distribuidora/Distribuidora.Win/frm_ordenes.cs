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

        public void LimpiarDatos()
        {
            listaOrdenesBindingSource.Clear();
            listaProveedoresBindingSource.Clear();
            listaProductosBindingSource.Clear();
        }

        public void RecargarDatos()
        {
            int posicion = listaOrdenesBindingSource.Position;
            LimpiarDatos();
            CargarDatos();
            listaOrdenesBindingSource.ResetBindings(true);
            listaOrdenesBindingSource.Position = posicion;
            EstadoBotones(true);
        }

        public void EstadoBotones(bool estado)
        {
            bindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
            panelDetalle.Enabled = !estado;
            bindingNavigatorSaveItem.Enabled = !estado;
        }


        public void Permisos(bool departamentoControlTotal)
        {
            
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

                if (resultado.Exitoso)
                {
                    RecargarDatos();
                }
                else
                    MessageBox.Show(resultado.Mensaje, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (esNuevo == false)
            {
                var ordenEditado = (orden_entrega)listaOrdenesBindingSource.Current;
                var resultado = _ordenesBL.EditarOrden(ordenEditado);

                if (resultado.Exitoso)
                {
                    RecargarDatos();
                }
                else
                    MessageBox.Show(resultado.Mensaje,"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _ordenesBL.AgregarOrden();
            listaOrdenesBindingSource.MoveLast();
            EstadoBotones(false);
            this.tabControl1.SelectedTab = tabPage2;
        }

        
        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
            esNuevo = false;
            EstadoBotones(false);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var ordenCancelada = (orden_entrega)listaOrdenesBindingSource.Current;
                _ordenesBL.CancelarOrden(ordenCancelada);
                EstadoBotones(true);
            }
            else if (esNuevo == false)
            {
                RecargarDatos();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var ordenEliminada = (orden_entrega)listaOrdenesBindingSource.Current;
            _ordenesBL.EliminarOrden(ordenEliminada);
            RecargarDatos();
        }

        private void listaOrdenesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void orden_detalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listaOrdenesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
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

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            var orden = (orden_entrega)listaOrdenesBindingSource.Current;
            var ordenDetalle = (orden_detalle)orden_detalleBindingSource.Current;

            _ordenesBL.RemoverOrdenDetalle(orden, ordenDetalle);
        }
    }
}
