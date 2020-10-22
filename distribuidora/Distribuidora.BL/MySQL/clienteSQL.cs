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
    class clienteSQL
    {
        public BindingList<cliente> select()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM cliente;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            cliente clien = null;
            var listaClientes = new BindingList<cliente>();

            while (reader.Read())
            {
                clien = new cliente();
                clien.clien_id = int.Parse(reader["clien_id"].ToString());
                clien.cliend_numid = reader["clien_numid"].ToString();
                clien.clien_pnom = reader["clien_pnom"].ToString();
                clien.clien_snom = reader["clien_snom"].ToString();
                clien.clien_pape = reader["clien_pape"].ToString();
                clien.clien_tel = reader["clien_tel"].ToString();

                listaClientes.Add(clien);
            }
            return listaClientes;
        }
    }
}
