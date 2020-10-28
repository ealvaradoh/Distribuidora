using Distribuidora.BL.Entidades;
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
        public BindingList<empleado> ListaEmpleados { get; set; }
        public BindingList<empleadoNombre> ListaNombreEmpleados { get; set; }
        public empleadosBL()
        {
            ListaEmpleados = new BindingList<empleado>();
            ListaNombreEmpleados = new BindingList<empleadoNombre>();
        }

        public resultado AutorizarEmpleado(string mail, string contraseña)
        {
            var resultado = new resultado();
            var listaEmpleados = ObtenerEmpleados();

            foreach(var empleado in listaEmpleados)
            {
                if (mail == empleado.emp_mail && contraseña == empleado.emp_mail_ctr)
                {
                    resultado.Exitoso = true;
                    resultado.departamentoID = empleado.depar_id;
                    return resultado;
                }
            }
            resultado.Mensaje = "Usuario o Contraseña no existe";
            return resultado;
        }

        public BindingList<empleado> ObtenerEmpleados()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM empleado;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            empleado emp = null;
            while (reader.Read())
            {
                emp = new empleado();
                emp.emp_id = int.Parse(reader["emp_id"].ToString());
                emp.emp_numid = reader["emp_numid"].ToString();
                emp.emp_pnom = reader["emp_pnom"].ToString();
                emp.emp_snom = reader["emp_snom"].ToString();
                emp.emp_pape = reader["emp_pape"].ToString();
                emp.emp_sape = reader["emp_sape"].ToString();
                emp.emp_fing = DateTime.Parse(reader["emp_fing"].ToString());
                emp.emp_mail = reader["emp_mail"].ToString();
                emp.emp_mail_ctr = reader["emp_mail_ctr"].ToString();
                emp.emp_activo = bool.Parse(reader["emp_activo"].ToString());
                emp.emp_tel = reader["emp_tel"].ToString();
                emp.depar_id = int.Parse(reader["depar_id"].ToString());

                ListaEmpleados.Add(emp);
            }
            return ListaEmpleados;
        }

        public BindingList<empleadoNombre> ObtenerNombreEmpleados()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT emp_id, CONCAT(emp_pnom, ' ', emp_snom, ' ', emp_pape, ' ', emp_sape) AS nombreEmpleado " +
                "FROM empleado;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            empleadoNombre emp = null;
            while (reader.Read())
            {
                emp = new empleadoNombre();
                emp.emp_id = int.Parse(reader["emp_id"].ToString());
                emp.nombreEmpleado = reader["nombreEmpleado"].ToString();

                ListaNombreEmpleados.Add(emp);
            }
            return ListaNombreEmpleados;
        }

        public BindingList<empleado> BuscarEmpleados(string descripcion)
        {
            var listaEmpleados = ObtenerEmpleados()
                .Where(empleado => empleado.emp_pnom.Contains(descripcion) == true).ToList();
            var ListaEmpleados = new BindingList<empleado>(listaEmpleados);
            return ListaEmpleados;
        }

        public class empleadoNombre
        {
            public int emp_id { get; set; }
            public string nombreEmpleado { get; set; }
        }
    }
}
