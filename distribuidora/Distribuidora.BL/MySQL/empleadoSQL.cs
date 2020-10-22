using Distribuidora.BL.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.MySQL
{
    public class empleadosSQL
    {
        public BindingList<empleado> select()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM empleado;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            empleado emp = null;
            var listaEmpleados = new BindingList<empleado>();

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

                listaEmpleados.Add(emp);
            }
            return listaEmpleados;
        }
    }
}

