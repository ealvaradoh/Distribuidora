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
    class cajeroSQL
    {
        public BindingList<cajero> select()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM cajero;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            cajero caje = null;
            var listaCajeros = new BindingList<cajero>();

            while (reader.Read())
            {
                caje = new cajero();
                caje.caje_id = int.Parse(reader["caje_id"].ToString());
                caje.caje_caja_asig = reader["caje_caja_asig"].ToString();
                caje.caje_fing = DateTime.Parse(reader["caje_fing"].ToString());
                caje.emp_id = int.Parse(reader["emp_id"].ToString());

                listaCajeros.Add(caje);
            }
            return listaCajeros;
        }
    }
}