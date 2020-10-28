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
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
        }

        public void EstadoBotones(bool estado)
        {
            listaClientesBindingNavigator.Enabled = estado;
            bindingNavigatorAddNewItem.Enabled = estado;
            bindingNavigatorCancelItem.Enabled = !estado;
        }

        public void Permisos(int departamentoID)
        {
            if(departamentoID == 1)
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else if (departamentoID == 2)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            _clientesBL.AgregarCliente();
            listaClientesBindingSource.MoveLast();
            EstadoBotones(false);
            listaClientesBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var clienteCancelado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.CancelarCliente(clienteCancelado);
                EstadoBotones(true);
                listaClientesBindingNavigatorSaveItem.Enabled = false;
            }
            else if(esNuevo == false)
            {
                EstadoBotones(true);
                listaClientesBindingNavigatorSaveItem.Enabled = false;
                listaClientesBindingSource.CancelEdit();
            }
        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (esNuevo == true)
            {
                var clienteGuardado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.GuardarCliente(clienteGuardado);
                listaClientesBindingSource.RemoveCurrent();

                listaClientesBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaClientesBindingNavigatorSaveItem.Enabled = false;
            }
            else if (esNuevo == false)
            {
                var clienteEditado = (cliente)listaClientesBindingSource.Current;
                _clientesBL.EditarCliente(clienteEditado);

                listaClientesBindingSource.ResetBindings(false);
                EstadoBotones(true);
                listaClientesBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            EstadoBotones(false);
            listaClientesBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var clienteEliminado = (cliente)listaClientesBindingSource.Current;
            _clientesBL.EliminarCliente(clienteEliminado);
        }
    }
}