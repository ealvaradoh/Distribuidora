using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribuidora.BL.BL;

namespace Distribuidora.Win
{
    public partial class frm_inicio : Form
    {
        contexto _contexto;
        public frm_inicio()
        {
            InitializeComponent();
            _contexto = new contexto();
        }

        frm_menu frm_menu;
        public void AbrirMenu()
        {
            frm_menu = new frm_menu();
            frm_menu.Show();
        }

        public static string server, database, user, pwd;

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        public void AsignarDatosMySQL()
        {
            server = txtServer.Text;
            database = txtDatabase.Text;
            user = txtUser.Text;
            pwd = txtPwd.Text;

            contexto.server = server;
            contexto.database = database;
            contexto.Uid = user;
            contexto.Pwd = pwd;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarDatosMySQL();
                btn_iniciar.Text = "Conectando...";
                btn_iniciar.Enabled = false;

                Application.DoEvents();
                _contexto.ConexionInicial();
                this.Hide();
                AbrirMenu();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_iniciar.Text = "Iniciar";
                btn_iniciar.Enabled = true;
            }
            
        }
    }
}
