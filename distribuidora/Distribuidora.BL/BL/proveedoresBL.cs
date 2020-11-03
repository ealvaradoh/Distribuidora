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
    public class proveedoresBL
    {
        public BindingList<proveedor> ListaProveedores { get; set; }
        public proveedoresBL()
        {
            ListaProveedores = new BindingList<proveedor>();
        }

        public BindingList<proveedor> ObtenerProveedores()
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "SELECT * FROM proveedor;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        proveedor prov = new proveedor();
                        prov.prov_id = int.Parse(reader["prov_id"].ToString());
                        prov.prov_rtn = reader["prov_rtn"].ToString();
                        prov.prov_nom = reader["prov_nom"].ToString();
                        prov.prov_pais = reader["prov_pais"].ToString();
                        prov.prov_dire = reader["prov_dire"].ToString();
                        prov.prov_tel = reader["prov_tel"].ToString();
                        prov.prov_mail = reader["prov_mail"].ToString();

                        ListaProveedores.Add(prov);
                    }
                }
                return ListaProveedores;
            }
            
        }

        public void AgregarProveedor()
        {
            var nuevoProveedor = new proveedor();
            ListaProveedores.Add(nuevoProveedor);
        }

        public void CancelarProveedor(proveedor proveedorCancelado)
        {
            ListaProveedores.Remove(proveedorCancelado);
        }

        public void GuardarProveedor(proveedor proveedorGuardado)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "INSERT INTO proveedor VALUES(@prov_id, @prov_rtn, @prov_nom, @prov_pais, @prov_dire, @prov_tel, @prov_mail);";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@prov_id", proveedorGuardado.prov_id);
                    comando.Parameters.AddWithValue("@prov_rtn", proveedorGuardado.prov_rtn);
                    comando.Parameters.AddWithValue("@prov_nom", proveedorGuardado.prov_nom);
                    comando.Parameters.AddWithValue("@prov_pais", proveedorGuardado.prov_pais);
                    comando.Parameters.AddWithValue("@prov_dire", proveedorGuardado.prov_dire);
                    comando.Parameters.AddWithValue("@prov_tel", proveedorGuardado.prov_tel);
                    comando.Parameters.AddWithValue("@prov_mail", proveedorGuardado.prov_mail);

                    comando.ExecuteNonQuery();
                }

                sql = "SELECT MAX(prov_id) AS nuevoProveedorId FROM proveedor;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        proveedorGuardado.prov_id = int.Parse(reader["nuevoProveedorId"].ToString());
                    }
                }
                ListaProveedores.Add(proveedorGuardado);
            }
        }
        public void EditarProveedor(proveedor proveedorEditado)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "UPDATE proveedor SET prov_rtn=@prov_rtn, prov_nom=@prov_nom, prov_pais=@prov_pais, prov_dire=@prov_dire, prov_tel=@prov_tel, prov_mail=@prov_mail WHERE prov_id = @prov_id;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@prov_id", proveedorEditado.prov_id);
                    comando.Parameters.AddWithValue("@prov_rtn", proveedorEditado.prov_rtn);
                    comando.Parameters.AddWithValue("@prov_nom", proveedorEditado.prov_nom);
                    comando.Parameters.AddWithValue("@prov_pais", proveedorEditado.prov_pais);
                    comando.Parameters.AddWithValue("@prov_dire", proveedorEditado.prov_dire);
                    comando.Parameters.AddWithValue("@prov_tel", proveedorEditado.prov_tel);
                    comando.Parameters.AddWithValue("@prov_mail", proveedorEditado.prov_mail);

                    comando.ExecuteNonQuery();
                }
            }
            
        }

        public void EliminarProveedor(proveedor proveedorEliminado)
        {
            MySqlConnection _contexto;

            using (_contexto = contexto.crearConexion())
            {
                string sql = "DELETE FROM proveedor WHERE prov_id= @prov_id;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@prov_id", proveedorEliminado.prov_id);

                    comando.ExecuteNonQuery();
                }
                ListaProveedores.Remove(proveedorEliminado);
            }
            
        }
    }
}
