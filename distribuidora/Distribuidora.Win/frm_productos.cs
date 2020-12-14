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
    public partial class frm_productos : Form
    {
        productosBL _productosBL;
        bool esNuevo;
        public frm_productos()
        {
            _productosBL = new productosBL();
            InitializeComponent();
            CargarDatos();
            Permisos();
        }

        public void CargarDatos()
        {
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }

        public void LimpiarDatos()
        {
            listaProductosBindingSource.Clear();
        }

        public void RecargarDatos()
        {
            int posicion = listaProductosBindingSource.Position;
            LimpiarDatos();
            CargarDatos();
            listaProductosBindingSource.ResetBindings(true);
            listaProductosBindingSource.Position = posicion;
            EstadoBotones(true);
        }

        public void EstadoBotones(bool estado)
        {
            listaProductosBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
            bindingNavigatorSaveItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
        }

        public void Permisos()
        {
            if (resultadoLogin.departamentoControlTotal == true)
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else if (resultadoLogin.departamentoControlTotal == false)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorEditItem.Enabled = false;
            }
        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var productoGuardado = (producto)listaProductosBindingSource.Current;
                _productosBL.GuardarProducto(productoGuardado);
                RecargarDatos();
            }
            else if (esNuevo == false)
            {
                var productoEditado = (producto)listaProductosBindingSource.Current;
                _productosBL.EditarProducto(productoEditado);
                RecargarDatos();
            }
        }

        private void listaProductosBindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            bindingNavigatorSaveItem.Enabled = true;
            tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var dlgRes = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dlgRes == DialogResult.Yes)
            {
                var productoEliminado = (producto)listaProductosBindingSource.Current;
                _productosBL.EliminarProducto(productoEliminado);
            }
        }

        private void listaProductosBindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var productoCancelado = (producto)listaProductosBindingSource.Current;
                _productosBL.CancelarProducto(productoCancelado);
                EstadoBotones(true);
            }
            else if (esNuevo == false)
            {
                RecargarDatos();
            }
        }

        private void listaProductosBindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _productosBL.AgregarProducto();
            listaProductosBindingSource.MoveLast();
            EstadoBotones(false);
            tabControl1.SelectedTab = tabPage2;
        }

        private void listaProductosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
