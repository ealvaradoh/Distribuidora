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
    public class departamentosBL
    {
        public BindingList<departamento> ListaDepartamentos { get; set; }
        public departamentosBL()
        {
            ListaDepartamentos = new BindingList<departamento>();
        }
        public BindingList<departamento> ObtenerDepartamentos()
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "SELECT * FROM departamento;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    departamento depart = null;
                    while (reader.Read())
                    {
                        depart = new departamento();
                        depart.depar_id = int.Parse(reader["depar_id"].ToString());
                        depart.depar_nom = reader["depar_nom"].ToString();
                        depart.depar_ctrl_total = bool.Parse(reader["depar_ctrl_total"].ToString());

                        ListaDepartamentos.Add(depart);
                    }
                }
                return ListaDepartamentos;
            }
            
        }
    }
}
