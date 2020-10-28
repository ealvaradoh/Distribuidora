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
    public class facturasBL
    {
        public BindingList<factura> ListaFacturas { get; set; }
        public facturasBL()
        {
            ListaFacturas = new BindingList<factura>();
        }

        public BindingList<factura> ObtenerFacturas()
        {
            string sql;
            MySqlDataReader reader;
            MySqlCommand comando;
            MySqlConnection _contexto = contexto.crearConexion();

            sql = "SELECT * FROM factura ORDER BY fact_id;";
            comando = new MySqlCommand(sql, _contexto);
            reader = comando.ExecuteReader();

            factura fact = null;
            while (reader.Read())
            {
                fact = new factura();
                fact.fact_id = int.Parse(reader["fact_id"].ToString());
                fact.fact_fecha = DateTime.Parse(reader["fact_fecha"].ToString());
                fact.clien_id = int.Parse(reader["clien_id"].ToString());
                fact.fact_subt = decimal.Parse(reader["fact_subt"].ToString());
                fact.fact_isv = decimal.Parse(reader["fact_isv"].ToString());
                fact.fact_total = decimal.Parse(reader["fact_total"].ToString());
                fact.caje_id = int.Parse(reader["caje_id"].ToString());

                ListaFacturas.Add(fact);
            }

            _contexto = contexto.crearConexion();
            sql = "SELECT * FROM factura_detalle ORDER BY fact_id;";
            comando = new MySqlCommand(sql, _contexto);
            reader = comando.ExecuteReader();

            factura_detalle fact_det = null;
            var Factura_Detalle = new BindingList<factura_detalle>();
            while (reader.Read())
            {
                fact_det = new factura_detalle();
                fact_det.fact_det_id = int.Parse(reader["fact_det_id"].ToString());
                fact_det.fact_id = int.Parse(reader["fact_id"].ToString());
                fact_det.produ_id = int.Parse(reader["produ_id"].ToString());
                fact_det.fact_det_cant = decimal.Parse(reader["fact_det_cant"].ToString());
                fact_det.fact_det_prec = decimal.Parse(reader["fact_det_prec"].ToString());
                fact_det.fact_det_total = decimal.Parse(reader["fact_det_total"].ToString());


                foreach (var factura in ListaFacturas)
                {
                    if (factura.fact_id == fact_det.fact_id)
                    {
                        factura.factura_detalle.Add(fact_det);
                    }
                }
            }
            return ListaFacturas;
        }

        public void AgregarFactura()
        {

            var nuevaFactura = new factura();
            ListaFacturas.Add(nuevaFactura);
        }

        public void AgregarFacturaDetalle(factura factura)
        {
            if(factura != null)
            {
                var nuevoDetalle = new factura_detalle();
                factura.factura_detalle.Add(nuevoDetalle);
            }
        }

        public void GuardarFactura()
        {
           
        }

        public void RemoverFacturaDetalle(factura factura, factura_detalle facturaDetalle)
        {
            if (factura != null && facturaDetalle != null)
            {
                factura.factura_detalle.Remove(facturaDetalle);
            }
        }

        public void CancelarFactura(factura facturaCancelada)
        {
            ListaFacturas.Remove(facturaCancelada);
        }
    }
}
