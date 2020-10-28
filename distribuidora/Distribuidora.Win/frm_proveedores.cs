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
            listaProveedoresBindingSource.DataSource = _proveedoresBL.ObtenerProveedores();
        }

        public void EstadoBotones(bool estado)
        {
            listaProveedoresBindingNavigator.Enabled = estado;
            bindingNavigatorAdd.Enabled = estado;
            bindingNavigatorCancel.Enabled = !estado;
        }

        private void bindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _proveedoresBL.AgregarProveedor();
            listaProveedoresBindingSource.MoveLast();
            EstadoBotones(false);
            bindingNavigatorSave.Enabled = true;
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            bindingNavigatorSave.Enabled = true;
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var proveedorCancelado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.CancelarProveedor(proveedorCancelado);
                EstadoBotones(true);
                bindingNavigatorSave.Enabled = false;
            }
            else if (esNuevo == false)
            {
                EstadoBotones(true);
                bindingNavigatorSave.Enabled = false;
                listaProveedoresBindingSource.CancelEdit();
            }
        }

        private void bindingNavigatorSave_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var proveedorGuardado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.GuardarProveedor(proveedorGuardado);
                listaProveedoresBindingSource.RemoveCurrent();

                listaProveedoresBindingSource.ResetBindings(false);
                EstadoBotones(true);
                bindingNavigatorSave.Enabled = false;
            }
            else if (esNuevo == false)
            {
                var proveedorEditado = (proveedor)listaProveedoresBindingSource.Current;
                _proveedoresBL.EditarProveedor(proveedorEditado);

                listaProveedoresBindingSource.ResetBindings(false);
                EstadoBotones(true);
                bindingNavigatorSave.Enabled = false;
            }
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            var proveedorEliminado = (proveedor)listaProveedoresBindingSource.Current;
            _proveedoresBL.EliminarProveedor(proveedorEliminado);
        }
    }
}
