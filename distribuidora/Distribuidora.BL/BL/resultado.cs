using Distribuidora.BL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.BL
{
    public class resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
        public int departamentoID { get; set; }
    }
}
