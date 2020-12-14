using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.Entidades
{
    public class cajero
    {
        public int caje_id { get; set; }
        public string caje_caja_asig { get; set; }
        public DateTime caje_fing { get; set; }
        public int emp_id { get; set; }
        public empleado empleado { get; set; }

        public cajero()
        {
            caje_fing = DateTime.Now;
        }
    }
}
