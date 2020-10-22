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
    public class departamentoSQL
    {
        public BindingList<departamento> select()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM departamento;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            departamento depart = null;
            var listaDepartamentos = new BindingList<departamento>();

            while (reader.Read())
            {
                depart = new departamento();
                depart.depar_id = int.Parse(reader["depar_id"].ToString());
                depart.depar_nom = reader["depar_nom"].ToString();

                listaDepartamentos.Add(depart);
            }
            return listaDepartamentos;
        }
    }
}
