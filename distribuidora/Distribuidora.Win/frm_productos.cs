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
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }

        public void EstadoBotones(bool estado)
        {
            listaProductosBindingNavigator.Enabled = estado;
            listaProductosBindingNavigatorAdd.Enabled = estado;
            listaProductosBindingNavigatorCancel.Enabled = !estado;
        }

        public void Permisos(int departamentoID)
        {
            if (departamentoID == 1)
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else if (departamentoID == 2)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                listaProductosBindingNavigatorEdit.Visible = false;
            }
        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var productoGuardado = (producto)listaProductosBindingSource.Current;
                _productosBL.GuardarProducto(productoGuardado);
                listaProductosBindingSource.RemoveCurrent();

                listaProductosBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaProductosBindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                var productoEditado = (producto)listaProductosBindingSource.Current;
                _productosBL.EditarProducto(productoEditado);

                listaProductosBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaProductosBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void listaProductosBindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            listaProductosBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var productoEliminado = (producto)listaProductosBindingSource.Current;
            _productosBL.EliminarProducto(productoEliminado);
        }

        private void listaProductosBindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var productoCancelado = (producto)listaProductosBindingSource.Current;
                _productosBL.CancelarProducto(productoCancelado);
                EstadoBotones(true);
                listaProductosBindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                EstadoBotones(true);
                listaProductosBindingNavigatorSaveItem.Enabled = false;
                listaProductosBindingSource.CancelEdit();
            }
        }

        private void listaProductosBindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _productosBL.AgregarProducto();
            listaProductosBindingSource.MoveLast();
            EstadoBotones(false);
            listaProductosBindingNavigatorSaveItem.Enabled = true;
        }
    }
}
