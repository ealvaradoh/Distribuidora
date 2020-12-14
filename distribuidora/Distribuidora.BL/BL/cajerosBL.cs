using Distribuidora.BL.Entidades;
using MySql.Data.MySqlClient;
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
        public BindingList<cajero> ListaCajeros { get; set; }
        public BindingList<cajeroNombre> ListaNombreCajeros { get; set; }
        public cajerosBL()
        {
            ListaCajeros = new BindingList<cajero>();
            ListaNombreCajeros = new BindingList<cajeroNombre>();
        }
        public BindingList<cajero> ObtenerCajeros()
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "SELECT * FROM cajero;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();

                    cajero caje = null;
                    while (reader.Read())
                    {
                        caje = new cajero();
                        caje.caje_id = int.Parse(reader["caje_id"].ToString());
                        caje.caje_caja_asig = reader["caje_caja_asig"].ToString();
                        caje.caje_fing = DateTime.Parse(reader["caje_fing"].ToString());
                        caje.emp_id = int.Parse(reader["emp_id"].ToString());

                        ListaCajeros.Add(caje);
                    }
                }
                return ListaCajeros;
            }
        }

        public BindingList<cajeroNombre> ObtenerNombreCajeros()
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "SELECT caje.`caje_id`, caje.`emp_id`, CONCAT(emple.`emp_pnom`,' ',emple.`emp_snom`,' ',emple.`emp_pape`,' ',emple.`emp_sape`) " +
                "AS empleado FROM cajero caje " +
                "INNER JOIN empleado emple ON caje.`emp_id` = emple.`emp_id` " +
                "ORDER BY emple.`emp_id`;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    cajeroNombre caje = null;
                    while (reader.Read())
                    {
                        caje = new cajeroNombre();
                        caje.caje_id = int.Parse(reader["caje_id"].ToString());
                        caje.emp_id = int.Parse(reader["emp_id"].ToString());
                        caje.empleadoNombre = reader["empleado"].ToString();

                        ListaNombreCajeros.Add(caje);
                    }
                }
                return ListaNombreCajeros;
            }
        }

        public void AgregarCajero()
        {
            var nuevoCajero = new cajero();
            ListaCajeros.Add(nuevoCajero);
        }

        public void CancelarCajero(cajero CajeroCancelado)
        {
            ListaCajeros.Remove(CajeroCancelado);
        }

        public void GuardarCajero(cajero CajeroGuardado)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "INSERT INTO cajero VALUES(@caje_id, @caje_caja_asig, @caje_fing, @emp_id);";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("caje_id", CajeroGuardado.caje_id);
                    comando.Parameters.AddWithValue("caje_caja_asig", CajeroGuardado.caje_caja_asig);
                    comando.Parameters.AddWithValue("caje_fing", CajeroGuardado.caje_fing);
                    comando.Parameters.AddWithValue("emp_id", CajeroGuardado.emp_id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EditarCajero(cajero CajeroEditado)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "UPDATE cajero SET caje_caja_asig=@caje_caja_asig, caje_fing=@caje_fing, emp_id=@emp_id WHERE caje_id = @caje_id;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("caje_id", CajeroEditado.caje_id);
                    comando.Parameters.AddWithValue("caje_caja_asig", CajeroEditado.caje_caja_asig);
                    comando.Parameters.AddWithValue("caje_fing", CajeroEditado.caje_fing);
                    comando.Parameters.AddWithValue("emp_id", CajeroEditado.emp_id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCajero(cajero CajeroEliminado)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "DELETE FROM cajero WHERE caje_id = @caje_id;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@caje_id", CajeroEliminado.caje_id);
                    comando.ExecuteNonQuery();
                }
                ListaCajeros.Remove(CajeroEliminado);
            }
        }

        public class cajeroNombre
        {
            public int caje_id { get; set; }
            public int emp_id { get; set; }
            public string empleadoNombre { get; set; }
        }

    }
}
