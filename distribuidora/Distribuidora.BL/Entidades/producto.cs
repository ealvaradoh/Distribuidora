using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.Entidades
{
    public class producto
    {
        public int produ_id { get; set; }
        public string produ_nom { get; set; }
        public decimal produ_prec { get; set; }
        public int produ_cant { get; set; }
    }
}
