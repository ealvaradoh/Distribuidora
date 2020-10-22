using Distribuidora.BL.Entidades;
using Distribuidora.BL.MySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.BL
{
    public class empleadosBL
    {
        empleadosSQL _empleadosSQL;
        public BindingList<empleado> ListaEmpleados { get; set; }
        public empleadosBL()
        {
            _empleadosSQL = new empleadosSQL();
            ListaEmpleados = new BindingList<empleado>();
        }

        public BindingList<empleado> ObtenerEmpleados()
        {
            ListaEmpleados = _empleadosSQL.select();
            return ListaEmpleados;
        }

        public BindingList<empleado> BuscarEmpleados(string descripcion)
        {
            var listaEmpleados = _empleadosSQL.select()
                .Where(empleado => empleado.emp_pnom.Contains(descripcion) == true).ToList();
            var ListaEmpleados = new BindingList<empleado>(listaEmpleados);
            return ListaEmpleados;
        }
    }
}
