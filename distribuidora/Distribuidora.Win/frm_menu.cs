using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribuidora.BL.MySQL;

namespace Distribuidora.Win
{
    public partial class frm_menu : Form
    {
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
            tsServer.Text = "Servidor: " + contexto.server;
            tsDatabase.Text = "BD: " + contexto.database;
            tsUsuario.Text = "Usuario: " + frm_login.usuario;
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
            tsServer.Text = "Servidor: " + contexto.server;
            tsDatabase.Text = "BD: " + contexto.database;
            tsUsuario.Text = "Usuario: " + frm_login.usuario;
        }
    }
}
