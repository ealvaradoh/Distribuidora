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
            listaCajerosBindingSource.DataSource = _cajerosBL.ObtenerCajeros();
            listaNombreEmpleadosBindingSource.DataSource = _empleadosBL.ObtenerNombreEmpleados();
        }

        public void EstadoBotones(bool estado)
        {
            listaCajerosBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _cajerosBL.AgregarCajero();
            listaCajerosBindingSource.MoveLast();
            EstadoBotones(false);
            listaCajerosBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var cajeroCancelado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.CancelarCajero(cajeroCancelado);
                EstadoBotones(true);
                listaCajerosBindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                EstadoBotones(true);
                listaCajerosBindingNavigatorSaveItem.Enabled = false;
                listaCajerosBindingSource.CancelEdit();
            }
        }

        private void listaCajerosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var cajeroGuardado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.GuardarCajero(cajeroGuardado);
                listaCajerosBindingSource.RemoveCurrent();

                listaCajerosBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaCajerosBindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                var cajeroEditado = (cajero)listaCajerosBindingSource.Current;
                _cajerosBL.EditarCajero(cajeroEditado);

                listaCajerosBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaCajerosBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            listaCajerosBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var cajeroEliminado = (cajero)listaCajerosBindingSource.Current;
            _cajerosBL.EliminarCajero(cajeroEliminado);
        }
    }
}
