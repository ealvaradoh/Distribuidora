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
    public partial class frm_menu : Form
    {
        public static bool DepartamentoControlTotal;
        public frm_menu()
        {
            InitializeComponent();
        }

        private void Login()
        {
            var frmLogin = new frm_login();
            frmLogin.MenuPrincipal = this;
            frmLogin.ShowDialog();
        }

        
        private void frm_menu_Load(object sender, EventArgs e)
        {
            Login();
            statusServidor.Text = "Servidor: " + contexto.server;
            StatusBD.Text = "Base de Datos: " + contexto.database;
            StatusUsuario.Text = "Usuario: " + resultadoLogin.empleadoNombre;
        }

        public frm_usuarios frm_usuarios;
        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_usuarios == null)
            {
                frm_usuarios = new frm_usuarios();
                frm_usuarios.MdiParent = this;
                frm_usuarios.Show();
            }
            else if (frm_usuarios.IsDisposed)
            {
                frm_usuarios = new frm_usuarios();
                frm_usuarios.MdiParent = this;
                frm_usuarios.Show();
            }
            else
                frm_usuarios.Activate();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
            statusServidor.Text = "Servidor: " + contexto.server;
            StatusBD.Text = "BD: " + contexto.database;
            StatusUsuario.Text = "Usuario: " + resultadoLogin.empleadoNombre;
        }

        public frm_clientes frm_clientes;
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_clientes == null)
            {
                frm_clientes = new frm_clientes();
                frm_clientes.MdiParent = this;
                frm_clientes.Show();
            }
            else if (frm_clientes.IsDisposed)
            {
                frm_clientes = new frm_clientes();
                frm_clientes.MdiParent = this;
                frm_clientes.Show();
            }
            else
                frm_clientes.Activate();
        }

        public frm_cajeros frm_cajeros;
        private void cajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_cajeros == null)
            {
                frm_cajeros = new frm_cajeros();
                frm_cajeros.MdiParent = this;
                frm_cajeros.Show();
            }
            else if (frm_cajeros.IsDisposed)
            {
                frm_cajeros = new frm_cajeros();
                frm_cajeros.MdiParent = this;
                frm_cajeros.Show();
            }
            else
                frm_cajeros.Activate();
        }

        public frm_productos frm_productos;
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_productos == null)
            {
                frm_productos = new frm_productos();
                frm_productos.MdiParent = this;
                frm_productos.Show();
            }
            else if (frm_productos.IsDisposed)
            {
                frm_productos = new frm_productos();
                frm_productos.MdiParent = this;
                frm_productos.Show();
            }
            else
                frm_productos.Activate();
        }

        public frm_facturas frm_facturas;
        public void AbrirFacturas()
        {
            if (frm_facturas == null)
            {
                frm_facturas = new frm_facturas();
                frm_facturas.MdiParent = this;
                frm_facturas.Show();
            }
            else if (frm_facturas.IsDisposed)
            {
                frm_facturas = new frm_facturas();
                frm_facturas.MdiParent = this;
                frm_facturas.Show();
            }
            else
                frm_facturas.Activate();
        }
        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFacturas();
        }

        public frm_proveedores frm_proveedores;
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_proveedores == null)
            {
                frm_proveedores = new frm_proveedores();
                frm_proveedores.MdiParent = this;
                frm_proveedores.Show();
            }
            else if (frm_proveedores.IsDisposed)
            {
                frm_proveedores = new frm_proveedores();
                frm_proveedores.MdiParent = this;
                frm_proveedores.Show();
            }
            else
                frm_proveedores.Activate();
        }

        public frm_ordenes frm_ordenes;
        public void AbrirOrdenes()
        {
            if (frm_ordenes == null)
            {
                frm_ordenes = new frm_ordenes();
                frm_ordenes.MdiParent = this;
                frm_ordenes.Show();
            }
            else if (frm_ordenes.IsDisposed)
            {
                frm_ordenes = new frm_ordenes();
                frm_ordenes.MdiParent = this;
                frm_ordenes.Show();
            }
            else
                frm_ordenes.Activate();
        }
        private void órdenesDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirOrdenes();
        }

        private void toolStripFacturas_Click(object sender, EventArgs e)
        {
            AbrirFacturas();
        }

        private void toolStripOrdenes_Click(object sender, EventArgs e)
        {
            AbrirOrdenes();
        }
    }
}
