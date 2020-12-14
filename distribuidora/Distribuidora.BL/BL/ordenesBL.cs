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
    public class ordenesBL
    {
        public BindingList<orden_entrega> ListaOrdenes { get; set; }
        public BindingList<orden_detalle> ListaOrdenesDetalle { get; set; }
        public ordenesBL()
        {
            ListaOrdenes = new BindingList<orden_entrega>();
            ListaOrdenesDetalle = new BindingList<orden_detalle>();
        }

        public BindingList<orden_entrega> ObtenerOrdenes()
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlOrden = "SELECT oe.`ord_id`, oe.`ord_fecha`, oe.`prov_id`, " +
                    "od.`ord_id` AS od_ord_id, od.`produ_id`, od.`ord_det_cant` " +
                    "FROM orden_entrega oe, orden_detalle od " +
                    "WHERE oe.`ord_id` = od.`ord_id` ORDER BY oe.`ord_id`;";
                using (MySqlCommand comando = new MySqlCommand(sqlOrden, _contexto))
                {

                    MySqlDataReader reader = comando.ExecuteReader();
                    orden_entrega ord = new orden_entrega();
                    ord.ord_id = 0;
                    orden_detalle ord_det = null;

                    int ord_idControl = 0;
                    bool ord_idRepite;
                    while (reader.Read())
                    {
                        // Orden de Entrega
                        ord_idControl = int.Parse(reader["ord_id"].ToString());
                        if (ord_idControl != ord.ord_id)
                        {

                            ord = new orden_entrega();
                            ord.ord_id = int.Parse(reader["ord_id"].ToString());
                            ord.ord_fecha = DateTime.Parse(reader["ord_fecha"].ToString());
                            ord.prov_id = int.Parse(reader["prov_id"].ToString());
                            ord_idRepite = false;
                        }
                        else
                            ord_idRepite = true;

                        // Factura Detalle
                        ord_det = new orden_detalle();
                        ord_det.ord_id = int.Parse(reader["od_ord_id"].ToString());
                        ord_det.produ_id = int.Parse(reader["produ_id"].ToString());
                        ord_det.ord_det_cant = decimal.Parse(reader["ord_det_cant"].ToString());

                        if (ord.ord_id == ord_det.ord_id)
                            ord.orden_detalle.Add(ord_det);

                        if (ord_idRepite == false)
                            ListaOrdenes.Add(ord);
                    }
                    reader.Close();
                    return ListaOrdenes;
                }
            }
        }

        public void AgregarOrden()
        {

            var nuevaOrden = new orden_entrega();
            ListaOrdenes.Add(nuevaOrden);
        }

        public void AgregarOrdenDetalle(orden_entrega orden)
        {
            if (orden != null)
            {
                var nuevoDetalle = new orden_detalle();
                orden.orden_detalle.Add(nuevoDetalle);
            }
        }

        public void EliminarOrden(orden_entrega orden)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlOrdenDetalle = "DELETE FROM orden_detalle WHERE ord_id = @ord_id";
                using (MySqlCommand comando = new MySqlCommand(sqlOrdenDetalle, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", orden.ord_id);
                    comando.ExecuteNonQuery();
                }

                string sqlOrden = "DELETE FROM orden_entrega WHERE ord_id = @ord_id";
                using (MySqlCommand comando = new MySqlCommand(sqlOrden, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", orden.ord_id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public resultado ValidaOrden(orden_entrega ord)
        {
            var resultado = new resultado();
            resultado.Exitoso = true;
            foreach (var ord_det in ord.orden_detalle)
            {
                if (ord_det.ord_det_cant > 100)
                {
                    resultado.Exitoso = false;
                    resultado.Mensaje = "No se pueden ingresar productos con una cantidad mayor a 100";
                    return resultado;
                }
                if (ord_det.produ_id == 0)
                {
                    resultado.Exitoso = false;
                    resultado.Mensaje = "Debe ingresar productos válidos";
                    return resultado;
                }
            }
            if (ord.prov_id == 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Debe ingresar un proveedor";
                return resultado;
            }
            if (ord.orden_detalle.Count == 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Debe ingresar detalle de orden";
                return resultado;
            }
            return resultado;
        }

        public resultado GuardarOrden(orden_entrega ordenGuardada)
        {
            var resultado = ValidaOrden(ordenGuardada);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlOrden = "INSERT INTO orden_entrega VALUES(@ord_id, @ord_fecha, @prov_id);";
                using (MySqlCommand comando = new MySqlCommand(sqlOrden, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", ordenGuardada.ord_id);
                    comando.Parameters.AddWithValue("@ord_fecha", ordenGuardada.ord_fecha);
                    comando.Parameters.AddWithValue("@prov_id", ordenGuardada.prov_id);

                    comando.ExecuteNonQuery();
                }

                string sqlNuevaOrdenId = "SELECT MAX(ord_id) AS nuevaOrdenID FROM orden_entrega;";
                using (MySqlCommand comando = new MySqlCommand(sqlNuevaOrdenId, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ordenGuardada.ord_id = int.Parse(reader["nuevaOrdenID"].ToString());
                    }
                    reader.Close();
                }

                string sqlFacturaDetalle = "INSERT INTO orden_detalle VALUES" +
                    "(@ord_id, @produ_id, @ord_det_cant);";
                using (MySqlCommand comando = new MySqlCommand(sqlFacturaDetalle, _contexto))
                {
                    var productoBL = new productosBL();
                    foreach (orden_detalle ord_det in ordenGuardada.orden_detalle)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@ord_id", ordenGuardada.ord_id);
                        comando.Parameters.AddWithValue("@produ_id", ord_det.produ_id);
                        comando.Parameters.AddWithValue("@ord_det_cant", ord_det.ord_det_cant);

                        comando.ExecuteNonQuery();
                        ListaOrdenesDetalle.Add(ord_det);
                    }
                    foreach (var ord_det in ListaOrdenesDetalle)
                    {
                        productoBL.SumaCantidad(ord_det.ord_det_cant, ord_det.produ_id);
                    }
                }
            }
            ListaOrdenesDetalle.Clear();
            return resultado;
        }

        public resultado EditarOrden(orden_entrega ordenEditada)
        {
            var resultado = ValidaOrden(ordenEditada);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                // Actualizar Orden
                string sqlOrden = "UPDATE orden_entrega SET " +
                        "ord_fecha=@ord_fecha, prov_id=@prov_id " +
                        "WHERE ord_id=@ord_id;";
                using (MySqlCommand comando = new MySqlCommand(sqlOrden, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", ordenEditada.ord_id);
                    comando.Parameters.AddWithValue("@ord_fecha", ordenEditada.ord_fecha);
                    comando.Parameters.AddWithValue("@prov_id", ordenEditada.prov_id);

                    comando.ExecuteNonQuery();
                }

                string sqlCantidadActual = "SELECT * FROM orden_detalle WHERE ord_id = @ord_id";
                using (MySqlCommand comando = new MySqlCommand(sqlCantidadActual, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", ordenEditada.ord_id);
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        orden_detalle ord_det = new orden_detalle();
                        ord_det.ord_id = int.Parse(reader["ord_id"].ToString());
                        ord_det.produ_id = int.Parse(reader["produ_id"].ToString());
                        ord_det.ord_det_cant = decimal.Parse(reader["ord_det_cant"].ToString());

                        ListaOrdenesDetalle.Add(ord_det);
                    }
                    comando.Parameters.Clear();
                    reader.Close();

                    var productoBL = new productosBL();
                    foreach (var ord_det in ListaOrdenesDetalle)
                    {
                        productoBL.RestaCantidad(ord_det.ord_det_cant, ord_det.produ_id);
                    }
                    ListaOrdenesDetalle.Clear();
                }
            }

            // Actualizar orden detalle
            using (_contexto = contexto.crearConexion())
            {
                string sqlOrdenDetalle = "DELETE FROM orden_detalle WHERE ord_id = @ord_id";
                using (MySqlCommand comando = new MySqlCommand(sqlOrdenDetalle, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", ordenEditada.ord_id);
                    comando.ExecuteNonQuery();
                }

                sqlOrdenDetalle = "INSERT INTO orden_detalle VALUES" +
                    "(@ord_id, @produ_id, @ord_det_cant);";
                using (MySqlCommand comando = new MySqlCommand(sqlOrdenDetalle, _contexto))
                {
                    var productoBL = new productosBL();
                    foreach (orden_detalle ord_det in ordenEditada.orden_detalle)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@ord_id", ordenEditada.ord_id);
                        comando.Parameters.AddWithValue("@produ_id", ord_det.produ_id);
                        comando.Parameters.AddWithValue("@ord_det_cant", ord_det.ord_det_cant);
                        comando.ExecuteNonQuery();
                        ListaOrdenesDetalle.Add(ord_det);
                    }
                    foreach (var ord_det in ListaOrdenesDetalle)
                    {
                        productoBL.SumaCantidad(ord_det.ord_det_cant, ord_det.produ_id);
                    }
                }
            }
            ListaOrdenesDetalle.Clear();
            return resultado;
        }

        public void RemoverOrdenDetalle(orden_entrega orden, orden_detalle ordenDetalle)
        {
            if (orden != null && ordenDetalle != null)
            {
                orden.orden_detalle.Remove(ordenDetalle);
            }
        }

        public void CancelarOrden(orden_entrega ordenCancelada)
        {
            ListaOrdenes.Remove(ordenCancelada);
        }
    }
}
