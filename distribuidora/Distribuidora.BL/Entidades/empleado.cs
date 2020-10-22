using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.Entidades
{
    public class empleado
    {
        public int emp_id { get; set; }
        public string emp_pnom { get; set; }
        public string emp_snom { get; set; }
        public string emp_pape { get; set; }
        public string emp_sape { get; set; }
        public string emp_mail { get; set; }
        public string emp_mail_ctr { get; set; }
        public DateTime emp_fing { get; set; }
        public bool emp_activo { get; set; }
        public int depar_id { get; set; }
        public departamento departamento { get; set; }
    }
}

