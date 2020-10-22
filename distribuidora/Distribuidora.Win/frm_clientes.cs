using Distribuidora.BL.BL;
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
        public frm_clientes()
        {
            _clientesBL = new clientesBL();
            InitializeComponent();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
        }
    }
}
