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
        public ordenesBL()
        {
            ListaOrdenes = new BindingList<orden_entrega>();
        }

        public BindingList<orden_entrega> ObtenerOrdenes()
        {
            string sql;
            MySqlDataReader reader;
            MySqlCommand comando;
            MySqlConnection _contexto = contexto.crearConexion();

            sql = "SELECT * FROM orden_entrega ORDER BY ord_id;";
            comando = new MySqlCommand(sql, _contexto);
            reader = comando.ExecuteReader();

            orden_entrega ord = null;
            while (reader.Read())
            {
                ord = new orden_entrega();
                ord.ord_id = int.Parse(reader["ord_id"].ToString());
                ord.ord_fecha = DateTime.Parse(reader["ord_fecha"].ToString());
                ord.ord_cant_produ = decimal.Parse(reader["ord_cant_produ"].ToString());
                ord.prov_id = int.Parse(reader["prov_id"].ToString());

                ListaOrdenes.Add(ord);
            }

            _contexto = contexto.crearConexion();
            sql = "SELECT * FROM orden_detalle ORDER BY ord_id;";
            comando = new MySqlCommand(sql, _contexto);
            reader = comando.ExecuteReader();

            orden_detalle ord_det = null;
            var Orden_Detalle = new BindingList<orden_detalle>();
            while (reader.Read())
            {
                ord_det = new orden_detalle();
                ord_det.ord_det_id = int.Parse(reader["ord_det_id"].ToString());
                ord_det.ord_id = int.Parse(reader["ord_id"].ToString());
                ord_det.produ_id = int.Parse(reader["produ_id"].ToString());
                ord_det.ord_det_cant = decimal.Parse(reader["ord_det_cant"].ToString());


                foreach (var orden in ListaOrdenes)
                {
                    if (orden.ord_id == ord_det.ord_id)
                    {
                        orden.orden_detalle.Add(ord_det);
                    }
                }
            }
            return ListaOrdenes;
        }

        public void AgregarOrden()
        {

            var nuevaOrden = new orden_entrega();
            ListaOrdenes.Add(nuevaOrden);
        }

        public void AgregarFacturaDetalle(orden_entrega orden)
        {
            if (orden != null)
            {
                var nuevoDetalle = new orden_detalle();
                orden.orden_detalle.Add(nuevoDetalle);
            }
        }

        public void GuardarFactura()
        {

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
