using Distribuidora.BL.Entidades;
using Distribuidora.BL.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.BL
{
    public class cajerosBL
    {
        cajeroSQL _cajeroSQL;
        public BindingList<cajero> ListaCajeros { get; set; }
        public cajerosBL()
        {
            _cajeroSQL = new cajeroSQL();
        }
        public BindingList<cajero> ObtenerCajeros()
        {
            ListaCajeros = _cajeroSQL.select();
            return ListaCajeros;
        }
    }
}
