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
                string sqlOrden = "SELECT oe.`ord_id`, oe.`ord_fecha`, oe.`ord_cant_produ`, oe.`prov_id`, " +
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
                            ord.ord_cant_produ = decimal.Parse(reader["ord_cant_produ"].ToString());
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

        public resultado ValidarOrden(orden_entrega ordenValida)
        {
            var resultado = new resultado();
            resultado.Exitoso = true;

            if (ordenValida.ord_cant_produ > 100)
            {
                resultado.Mensaje = "No puede entregar una cantidad de más de 100 productos";
                resultado.Exitoso = false;
            }
            return resultado;
        }

        public resultado GuardarOrden(orden_entrega ordenGuardada)
        {
            var resultado = ValidarOrden(ordenGuardada);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlOrden = "INSERT INTO orden_entrega VALUES(@ord_id, @ord_fecha, @ord_cant_produ, @prov_id);";
                using (MySqlCommand comando = new MySqlCommand(sqlOrden, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", ordenGuardada.ord_id);
                    comando.Parameters.AddWithValue("@ord_fecha", ordenGuardada.ord_fecha);
                    comando.Parameters.AddWithValue("@ord_cant_produ", ordenGuardada.ord_cant_produ);
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
                    foreach (orden_detalle ord_det in ordenGuardada.orden_detalle)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@ord_id", ordenGuardada.ord_id);
                        comando.Parameters.AddWithValue("@produ_id", ord_det.produ_id);
                        comando.Parameters.AddWithValue("@ord_det_cant", ord_det.ord_det_cant);

                        comando.ExecuteNonQuery();
                        ListaOrdenesDetalle.Add(ord_det);
                    }
                }
                ordenGuardada.orden_detalle = ListaOrdenesDetalle;
                ListaOrdenes.Add(ordenGuardada);
            }
            return resultado;
        }

        public void EditarOrden(orden_entrega ordenEditada)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                // Actualizar Orden
                string sqlOrden = "UPDATE orden_entrega SET " +
                        "ord_fecha=@ord_fecha, ord_cant_produ=@ord_cant_produ, prov_id=@prov_id " +
                        "WHERE ord_id=@ord_id;";
                using (MySqlCommand comando = new MySqlCommand(sqlOrden, _contexto))
                {
                    comando.Parameters.AddWithValue("@ord_id", ordenEditada.ord_id);
                    comando.Parameters.AddWithValue("@ord_fecha", ordenEditada.ord_fecha);
                    comando.Parameters.AddWithValue("@ord_cant_produ", ordenEditada.ord_cant_produ);
                    comando.Parameters.AddWithValue("@prov_id", ordenEditada.prov_id);

                    comando.ExecuteNonQuery();
                }

                // Actualizar orden detalle
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
                    foreach (orden_detalle ord_det in ordenEditada.orden_detalle)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@ord_id", ordenEditada.ord_id);
                        comando.Parameters.AddWithValue("@produ_id", ord_det.produ_id);
                        comando.Parameters.AddWithValue("@ord_det_cant", ord_det.ord_det_cant);

                        comando.ExecuteNonQuery();
                    }
                }
            }
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
