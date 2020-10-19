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
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
