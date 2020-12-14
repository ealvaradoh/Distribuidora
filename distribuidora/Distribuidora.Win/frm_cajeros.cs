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
    public partial class frm_cajeros : Form
    {
        cajerosBL _cajerosBL;
        empleadosBL _empleadosBL;
        bool esNuevo;

        public frm_cajeros()
        {
            _cajerosBL = new cajerosBL();
            _empleadosBL = new empleadosBL();
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            listaCajerosBindingSource.DataSource = _cajerosBL.ObtenerCajeros();
            listaNombreEmpleadosBindingSource.DataSource = _empleadosBL.ObtenerEmpleadosCajeros();
        }

        public void LimpiarDatos()
        {
            listaCajerosBindingSource.Clear();
            listaNombreEmpleadosBindingSource.Clear();
        }

        public void RecargarDatos()
        {
            int posicion = listaCajerosBindingSource.Position;
            LimpiarDatos();
            CargarDatos();
            listaCajerosBindingSource.ResetBindings(true);
            listaCajerosBindingSource.Position = posicion;
            EstadoBotones(true);
        }

        public void EstadoBotones(bool estado)
        {
            listaCajerosBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
            BindingNavigatorSaveItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _cajerosBL.AgregarCajero();
            listaCajerosBindingSource.MoveLast();
            EstadoBotones(false);
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var cajeroCancelado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.CancelarCajero(cajeroCancelado);
                EstadoBotones(true);
            }
            else if (esNuevo == false)
            {
                RecargarDatos();
            }
        }

        private void listaCajerosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var cajeroGuardado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.GuardarCajero(cajeroGuardado);
                RecargarDatos();
            }
            else if (esNuevo == false)
            {
                var cajeroEditado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.EditarCajero(cajeroEditado);
                RecargarDatos();
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            BindingNavigatorSaveItem.Enabled = true;
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            var dlgRes = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dlgRes == DialogResult.Yes)
            {
                var cajeroEliminado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.EliminarCajero(cajeroEliminado);
            }
        }

        private void listaCajerosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void listaCajerosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
