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
    public partial class frm_clientes : Form
    {
        clientesBL _clientesBL;
        bool esNuevo;
        public frm_clientes()
        {
            _clientesBL = new clientesBL();
            InitializeComponent();
            CargarDatos();
            Permisos();
        }

        public void CargarDatos()
        {
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
        }

        public void LimpiarDatos()
        {
            listaClientesBindingSource.Clear();
        }

        public void RecargarDatos()
        {
            int posicion = listaClientesBindingSource.Position;
            LimpiarDatos();
            CargarDatos();
            listaClientesBindingSource.ResetBindings(false);
            listaClientesBindingSource.Position = posicion;
            EstadoBotones(true);
        }

        public void EstadoBotones(bool estado)
        {
            listaClientesBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
            bindingNavigatorSaveItem.Enabled = !estado;
            panelDatos.Enabled = !estado;
        }

        public void Permisos()
        {
            bindingNavigatorDelete.Enabled = 
                resultadoLogin.departamentoControlTotal;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _clientesBL.AgregarCliente();
            listaClientesBindingSource.MoveLast();
            EstadoBotones(false);
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var clienteCancelado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.CancelarCliente(clienteCancelado);
                EstadoBotones(true);
            }
            else if(esNuevo == false)
            {
                RecargarDatos();
            }
        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var clienteGuardado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.GuardarCliente(clienteGuardado);
                RecargarDatos();
            }
            else if (esNuevo == false)
            {
                var clienteEditado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.EditarCliente(clienteEditado);
                RecargarDatos();
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var dlgRes = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dlgRes == DialogResult.Yes)
            {
                var clienteEliminado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.EliminarCliente(clienteEliminado);
            }
        }

        private void listaClientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }
    }
}