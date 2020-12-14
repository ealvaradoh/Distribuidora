using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Distribuidora.BL.BL;
using Distribuidora.BL.Entidades;

namespace Distribuidora.Win
{
    public partial class frm_login : Form
    {
        public frm_menu MenuPrincipal { get; set; }
        empleadosBL _empleadoBL;

        public frm_login()
        {
            _empleadoBL = new empleadosBL();
            InitializeComponent();

            List<TextBox> usuarioTlist = new List<TextBox>();
            List<string> usuarioSlist = new List<String>();
            usuarioTlist.Add(txtUsuario);
            usuarioSlist.Add("Usuario (Mail)");
            SetCueBanner(ref usuarioTlist, usuarioSlist);

            List<TextBox> contrasenaTlist = new List<TextBox>();
            List<string> contrasenaSlist = new List<String>();
            contrasenaTlist.Add(txtContraseña);
            contrasenaSlist.Add("Contraseña");
            SetCueBanner(ref contrasenaTlist, contrasenaSlist);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string usuario, contra;
        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Datos usuario que inicia sesión
            usuario = txtUsuario.Text;
            contra = txtContraseña.Text;

            var resultadoLogin = _empleadoBL.AutorizarEmpleado(usuario, contra);
            if (resultadoLogin.Exitoso == true)
            {
                MenuPrincipal.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(resultadoLogin.Mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnIngresar.Enabled = true;
            btnIngresar.Text = "Conectar";
        }
    }
}
