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
    public partial class frm_usuarios : Form
    {
        empleadosBL _empleadosBL;
        departamentoBL _departamentoBL;
        public frm_usuarios()
        {
            InitializeComponent();
            _empleadosBL = new empleadosBL();
            _departamentoBL = new departamentoBL();
            listaEmpleadosBindingSource.DataSource = _empleadosBL.ObtenerEmpleados();
            listaDepartamentosBindingSource.DataSource = _departamentoBL.ObtenerDepartamentos();
        }
    }
}
