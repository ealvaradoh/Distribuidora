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
    public class clientesBL
    {
        public BindingList<cliente> ListaClientes { get; set; }
        public clientesBL()
        {
            ListaClientes = new BindingList<cliente>();
        }
        public BindingList<cliente> ObtenerClientes()
        {
            MySqlDataReader reader;
            MySqlConnection _contexto = contexto.crearConexion();

            string sql = "SELECT * FROM cliente;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cliente clien = new cliente();
                clien.clien_id = int.Parse(reader["clien_id"].ToString());
                clien.clien_numid = reader["clien_numid"].ToString();
                clien.clien_nom = reader["clien_nom"].ToString();
                clien.clien_tel = reader["clien_tel"].ToString();

                ListaClientes.Add(clien);
            }

            return ListaClientes;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public void CancelarCliente(cliente clienteCancelado)
        {
            ListaClientes.Remove(clienteCancelado);
        }

        public void GuardarCliente(cliente clienteGuardado)
        {
            MySqlDataReader reader;
            MySqlConnection _contexto; 
            string sql;
            
            _contexto = contexto.crearConexion();
            sql = "INSERT INTO cliente VALUES(@clien_id, @clien_numid, @clien_nom, @clien_tel);";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            comando.Parameters.AddWithValue("@clien_id", clienteGuardado.clien_id);
            comando.Parameters.AddWithValue("@clien_numid", clienteGuardado.clien_numid);
            comando.Parameters.AddWithValue("@clien_nom", clienteGuardado.clien_nom);
            comando.Parameters.AddWithValue("@clien_tel", clienteGuardado.clien_tel);

            comando.ExecuteNonQuery();


            _contexto = contexto.crearConexion();
            sql = "SELECT MAX(clien_id) AS nuevoClienteId FROM cliente;";
            comando = new MySqlCommand(sql, _contexto);

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                clienteGuardado.clien_id = int.Parse(reader["nuevoClienteId"].ToString());
            }

            ListaClientes.Add(clienteGuardado);
        }

        public void EditarCliente(cliente clienteEditado)
        {
            MySqlConnection _contexto = contexto.crearConexion();
            string sql;

            sql = "UPDATE cliente SET clien_numid=@clien_numid, clien_nom=@clien_nom, clien_tel=@clien_tel WHERE clien_id = @clien_id;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            comando.Parameters.AddWithValue("@clien_id", clienteEditado.clien_id);
            comando.Parameters.AddWithValue("@clien_numid", clienteEditado.clien_numid);
            comando.Parameters.AddWithValue("@clien_nom", clienteEditado.clien_nom);
            comando.Parameters.AddWithValue("@clien_tel", clienteEditado.clien_tel);

            comando.ExecuteNonQuery();
        }

        public void EliminarCliente(cliente clienteEliminado)
        {
            MySqlConnection _contexto = contexto.crearConexion();
            string sql;

            sql = "DELETE FROM cliente WHERE clien_id = @clien_id;";
            MySqlCommand comando = new MySqlCommand(sql, _contexto);

            comando.Parameters.AddWithValue("@clien_id", clienteEliminado.clien_id);

            comando.ExecuteNonQuery();
            ListaClientes.Remove(clienteEliminado);
        }
    }
}
