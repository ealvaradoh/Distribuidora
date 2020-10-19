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
using Distribuidora.BL;

namespace Distribuidora.Win
{
    public partial class frm_login : Form
    {
        public frm_menu MenuPrincipal { get; set; }
        public frm_login Login { get; set; }
        public frm_login()
        {
            InitializeComponent();

            List<TextBox> usuarioTlist = new List<TextBox>();
            List<string> usuarioSlist = new List<String>();
            usuarioTlist.Add(txtUsuario);
            usuarioSlist.Add("Usuario");
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

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Contexto.crearConexion();
            this.Close();
        }
    }
}
