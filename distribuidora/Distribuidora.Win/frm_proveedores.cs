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
    public partial class frm_proveedores : Form
    {
        proveedoresBL _proveedoresBL;
        bool esNuevo;
        public frm_proveedores()
        {
            _proveedoresBL = new proveedoresBL();
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            listaProveedoresBindingSource.DataSource = _proveedoresBL.ObtenerProveedores();
        }

        public void LimpiarDatos()
        {
            listaProveedoresBindingSource.Clear();
        }

        public void RecargarDatos()
        {
            int posicion = listaProveedoresBindingSource.Position;
            LimpiarDatos();
            CargarDatos();
            listaProveedoresBindingSource.ResetBindings(true);
            listaProveedoresBindingSource.Position = posicion;
            EstadoBotones(true);
        }

        public void EstadoBotones(bool estado)
        {
            listaProveedoresBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelNewItem.Enabled = !estado;
            bindingNavigatorSaveItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
        }

        private void bindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _proveedoresBL.AgregarProveedor();
            listaProveedoresBindingSource.MoveLast();
            EstadoBotones(false);
            tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            bindingNavigatorSaveItem.Enabled = true;
            tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var proveedorCancelado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.CancelarProveedor(proveedorCancelado);
                EstadoBotones(true);
            }
            else if (esNuevo == false)
            {
                RecargarDatos();
            }
        }

        private void bindingNavigatorSave_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var proveedorGuardado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.GuardarProveedor(proveedorGuardado);
                RecargarDatos();
            }
            else if (esNuevo == false)
            {
                var proveedorEditado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.EditarProveedor(proveedorEditado);
                RecargarDatos();
            }
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            var dlgRes = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dlgRes == DialogResult.Yes)
            {
                var proveedorEliminado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.EliminarProveedor(proveedorEliminado);
            }
        }

        private void listaProveedoresDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
