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
    public partial class frm_cajeros : Form
    {
        cajerosBL _cajerosBL;
        empleadosBL _empleadosBL;
        public frm_cajeros()
        {
            _cajerosBL = new cajerosBL();
            _empleadosBL = new empleadosBL();
            InitializeComponent();
            listaCajerosBindingSource.DataSource = _cajerosBL.ObtenerCajeros();
            listaEmpleadosBindingSource.DataSource = _empleadosBL.ObtenerEmpleados();
        }
    }
}
