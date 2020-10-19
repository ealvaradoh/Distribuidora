using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL
{
    public class Contexto
    {
        public static MySqlConnection crearConexion()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "Server = localhost; Database = aerolinea; Uid = root; Pwd = 07adviser;";
            conexion.Open();
            return conexion;
        }
    }
}
