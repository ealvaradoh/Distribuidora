using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.BL
{
    public class contexto
    {
        public static string server, database, Uid, Pwd;
        public static MySqlConnection crearConexion()
        {
            string conxStr = string.Format(
                "Server = {0}; Database = {1}; Uid = {2}; Pwd = {3};", server, database, Uid, Pwd);

            MySqlConnection conexion = new MySqlConnection(conxStr);
            conexion.Open();
            return conexion;
        }
    }
}
