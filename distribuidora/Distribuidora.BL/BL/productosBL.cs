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
    public class productosBL
    {
        public BindingList<producto> ListaProductos { get; set; }
        public productosBL()
        {
            ListaProductos = new BindingList<producto>();
        }

        public BindingList<producto> ObtenerProductos()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM producto;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();

            producto produ = null;
            while (reader.Read())
            {
                produ = new producto();
                produ.produ_id = int.Parse(reader["produ_id"].ToString());
                produ.produ_nom = reader["produ_nom"].ToString();
                produ.produ_prec = decimal.Parse(reader["produ_prec"].ToString());
                ListaProductos.Add(produ);
            }
            return ListaProductos;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new producto();
            ListaProductos.Add(nuevoProducto);
        }

        public void CancelarProducto(producto productoCancelado)
        {
            ListaProductos.Remove(productoCancelado);
        }

        public void GuardarProducto(producto productoGuardado)
        {
            MySqlDataReader reader;
            MySqlConnection _contexto;
            string sql;

            _contexto = contexto.crearConexion();
            sql = "INSERT INTO producto VALUES(@produ_id, @produ_nom, @produ_prec);";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            comando.Parameters.AddWithValue("@produ_id", productoGuardado.produ_id);
            comando.Parameters.AddWithValue("@produ_nom", productoGuardado.produ_nom);
            comando.Parameters.AddWithValue("@produ_prec", productoGuardado.produ_prec);

            comando.ExecuteNonQuery();


            _contexto = contexto.crearConexion();
            sql = "SELECT MAX(produ_id) AS nuevoProductoId FROM producto;";
            comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                productoGuardado.produ_id = int.Parse(reader["nuevoProductoId"].ToString());
            }

            ListaProductos.Add(productoGuardado);
        }

        public void EditarProducto(producto productoEditado)
        {
            MySqlConnection _contexto = contexto.crearConexion();
            string sql;

            sql = "UPDATE producto SET produ_nom=@produ_nom, produ_prec=@produ_prec WHERE produ_id = @produ_id;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            comando.Parameters.AddWithValue("@produ_nom", productoEditado.produ_nom);
            comando.Parameters.AddWithValue("@produ_prec", productoEditado.produ_prec);
            comando.Parameters.AddWithValue("@produ_id", productoEditado.produ_id);

            comando.ExecuteNonQuery();
        }

        public void EliminarProducto(producto productoEliminado)
        {
            MySqlConnection _contexto = contexto.crearConexion();
            string sql;

            sql = "DELETE FROM producto WHERE produ_id = @produ_id;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            comando.Parameters.AddWithValue("@produ_id", productoEliminado.produ_id);

            comando.ExecuteNonQuery();
            ListaProductos.Remove(productoEliminado);
        }
    }
}
