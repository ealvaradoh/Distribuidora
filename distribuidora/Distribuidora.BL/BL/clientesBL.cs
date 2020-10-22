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
    public class clientesBL
    {
        clienteSQL _clienteSQL;
        public BindingList<cliente> ListaClientes { get; set; }
        public clientesBL()
        {
            _clienteSQL = new clienteSQL();
        }
        public BindingList<cliente> ObtenerClientes()
        {
            ListaClientes = _clienteSQL.select();
            return ListaClientes;
        }
    }
}
