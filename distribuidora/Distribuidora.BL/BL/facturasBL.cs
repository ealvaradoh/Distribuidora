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
        public BindingList<factura_detalle> ListaFacturasDetalle { get; set; }
        public facturasBL()
        {
            ListaFacturas = new BindingList<factura>();
            ListaFacturasDetalle = new BindingList<factura_detalle>();
        }

        public BindingList<factura> ObtenerFacturas()
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlFactura = "SELECT f.`fact_id`, f.`fact_fecha`, f.`clien_id`, f.`fact_subt`, f.`fact_isv`, f.`fact_total`, f.`caje_id`, " +
                    "fd.`fact_id` AS fd_fact_id, fd.`produ_id`, fd.`fact_det_cant`, fd.`fact_det_prec`, fd.`fact_det_total` " +
                    "FROM factura f, factura_detalle fd " +
                    "WHERE f.`fact_id` = fd.`fact_id` ORDER BY f.`fact_id`;";
                using (MySqlCommand comando = new MySqlCommand(sqlFactura, _contexto))
                {

                    MySqlDataReader reader = comando.ExecuteReader();
                    factura fact = new factura();
                    fact.fact_id = 0;
                    factura_detalle fact_det = null;

                    int fact_idControl = 0;
                    bool fact_idRepite;
                    while (reader.Read())
                    {
                        // Factura
                        fact_idControl = int.Parse(reader["fact_id"].ToString());
                        if (fact_idControl != fact.fact_id)
                        {
                            
                            fact = new factura();
                            fact.fact_id = int.Parse(reader["fact_id"].ToString());
                            fact.fact_fecha = DateTime.Parse(reader["fact_fecha"].ToString());
                            fact.clien_id = int.Parse(reader["clien_id"].ToString());
                            fact.fact_subt = decimal.Parse(reader["fact_subt"].ToString());
                            fact.fact_isv = decimal.Parse(reader["fact_isv"].ToString());
                            fact.fact_total = decimal.Parse(reader["fact_total"].ToString());
                            fact.caje_id = int.Parse(reader["caje_id"].ToString());
                            fact_idRepite = false;
                        }
                        else
                            fact_idRepite = true;

                        // Factura Detalle
                        fact_det = new factura_detalle();
                        fact_det.fact_id = int.Parse(reader["fd_fact_id"].ToString());
                        fact_det.produ_id = int.Parse(reader["produ_id"].ToString());
                        fact_det.fact_det_cant = decimal.Parse(reader["fact_det_cant"].ToString());
                        fact_det.fact_det_prec = decimal.Parse(reader["fact_det_prec"].ToString());
                        fact_det.fact_det_total = decimal.Parse(reader["fact_det_total"].ToString());

                        if (fact.fact_id == fact_det.fact_id)
                            fact.factura_detalle.Add(fact_det);

                        if (fact_idRepite == false)
                            ListaFacturas.Add(fact);
                    }
                    reader.Close();
                    return ListaFacturas;
                }
            }
        }

        public resultado AutorizaCajeroAtiende(factura nuevaFactura)
        {
            var resultado = new resultado();
            resultado.Exitoso = true;
            nuevaFactura.caje_id = 0;

            MySqlConnection _contexto;
            string sql = "SELECT emp.`emp_id`, caje.`caje_id` " +
                    "FROM empleado emp, cajero caje " +
                    "WHERE emp.`emp_id` = caje.`emp_id` AND emp.`emp_mail` = @mail;";
            resultadoLogin.cajeroID = 0;
            using (_contexto = contexto.crearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@mail", resultadoLogin.empleadoMail);
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        nuevaFactura.caje_id = int.Parse(reader["caje_id"].ToString());
                    }
                }
                if (nuevaFactura.caje_id == 0)
                {
                    resultado.Exitoso = false;
                    resultado.Mensaje = "El empleado no está autorizado para hacer facturas";
                }
            }
            return resultado;
        }

        public resultado AgregarFactura()
        {
            var nuevaFactura = new factura();
            nuevaFactura.caje_id = resultadoLogin.cajeroID;
            var resultado = AutorizaCajeroAtiende(nuevaFactura);

            if (resultado.Exitoso == false)
                return resultado;
            else
                ListaFacturas.Add(nuevaFactura); 

            return resultado;
        }

        public void AgregarFacturaDetalle(factura factura)
        {
            if(factura != null)
            {
                var nuevoDetalle = new factura_detalle();
                factura.factura_detalle.Add(nuevoDetalle);
            }
        }

        public resultado ValidarFactura(factura facturaValida)
        {
            var resultado = new resultado();
            int cantidadFacturasDia = 0; 
            resultado.Exitoso = true;
            
            if (facturaValida == null)
            {
                resultado.Mensaje = "Agregue todos los datos de la factura";
                resultado.Exitoso = false;
                return resultado;
            }
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sql = "SELECT COUNT(fact_id) AS cantidadFacturaDia FROM factura WHERE caje_id = @caje_id AND fact_fecha = @fact_fecha;";
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@caje_id", facturaValida.caje_id);
                    comando.Parameters.AddWithValue("@fact_fecha", Convert.ToDateTime(facturaValida.fact_fecha).ToString("yyyy-MM-dd"));
                    MySqlDataReader reader = comando.ExecuteReader();
                    while(reader.Read())
                    {
                        cantidadFacturasDia = int.Parse(reader["cantidadFacturaDia"].ToString());
                    }
                }
            }
            if (cantidadFacturasDia >= 80)
            {
                resultado.Mensaje = "Este cajero no puede hacer más facturas por hoy";
                resultado.Exitoso = false;
            }
            if (facturaValida.clien_id == 0)
            {
                resultado.Mensaje = "Agregue un cliente";
                resultado.Exitoso = false;
            }
            if (facturaValida.factura_detalle.Count == 0)
            {
                resultado.Mensaje = "Agregue productos al detalle";
                resultado.Exitoso = false;
            }
            foreach(var fact_det in facturaValida.factura_detalle)
            {
                if (fact_det.produ_id == 0)
                {
                    resultado.Mensaje = "Elija un producto válido";
                    resultado.Exitoso = false;
                }
            }
            return resultado;
        }

        public resultado GuardarFactura(factura facturaGuardada)
        {
            var resultado = ValidarFactura(facturaGuardada);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlFactura = "INSERT INTO factura VALUES(@fact_id, @fact_fecha, @clien_id, @fact_subt, @fact_isv, @fact_total, @caje_id);";
                using (MySqlCommand comando = new MySqlCommand(sqlFactura, _contexto))
                {
                    comando.Parameters.AddWithValue("@fact_id", facturaGuardada.fact_id);
                    comando.Parameters.AddWithValue("@fact_fecha", facturaGuardada.fact_fecha);
                    comando.Parameters.AddWithValue("@clien_id", facturaGuardada.clien_id);
                    comando.Parameters.AddWithValue("@fact_subt", facturaGuardada.fact_subt);
                    comando.Parameters.AddWithValue("@fact_isv", facturaGuardada.fact_isv);
                    comando.Parameters.AddWithValue("@fact_total", facturaGuardada.fact_total);
                    comando.Parameters.AddWithValue("@caje_id", facturaGuardada.caje_id);

                    comando.ExecuteNonQuery();
                }

                string sqlNuevoFacturaID = "SELECT MAX(fact_id) AS nuevoFacturaID FROM factura;";
                using (MySqlCommand comando = new MySqlCommand(sqlNuevoFacturaID, _contexto))
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        facturaGuardada.fact_id = int.Parse(reader["nuevoFacturaID"].ToString());
                    }
                    reader.Close();
                }

                string sqlFacturaDetalle = "INSERT INTO factura_detalle VALUES" +
                    "(@fact_id, @produ_id, @fact_det_cant, @fact_det_prec, @fact_det_total);";
                using (MySqlCommand comando = new MySqlCommand(sqlFacturaDetalle, _contexto))
                {
                    foreach (factura_detalle fact_det in facturaGuardada.factura_detalle)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@fact_id", facturaGuardada.fact_id);
                        comando.Parameters.AddWithValue("@produ_id", fact_det.produ_id);
                        comando.Parameters.AddWithValue("@fact_det_cant", fact_det.fact_det_cant);
                        comando.Parameters.AddWithValue("@fact_det_prec", fact_det.fact_det_prec);
                        comando.Parameters.AddWithValue("@fact_det_total", fact_det.fact_det_total);

                        comando.ExecuteNonQuery();
                        ListaFacturasDetalle.Add(fact_det);
                    }
                }
                facturaGuardada.factura_detalle = ListaFacturasDetalle;
                ListaFacturas.Add(facturaGuardada);
            }
            return resultado;
        }

        public resultado EditarFactura(factura facturaEditada)
        {
            var resultado = ValidarFactura(facturaEditada);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                // Actualizar Factura
                string sqlFactura = "UPDATE factura SET " +
                        "fact_fecha=@fact_fecha, clien_id=@clien_id, fact_subt=@fact_subt, fact_isv=@fact_isv, fact_total=@fact_total, caje_id=@caje_id " +
                        "WHERE fact_id=@fact_id;";
                using (MySqlCommand comando = new MySqlCommand(sqlFactura, _contexto))
                {
                    comando.Parameters.AddWithValue("@fact_id", facturaEditada.fact_id);
                    comando.Parameters.AddWithValue("@fact_fecha", facturaEditada.fact_fecha);
                    comando.Parameters.AddWithValue("@clien_id", facturaEditada.clien_id);
                    comando.Parameters.AddWithValue("@fact_subt", facturaEditada.fact_subt);
                    comando.Parameters.AddWithValue("@fact_isv", facturaEditada.fact_isv);
                    comando.Parameters.AddWithValue("@fact_total", facturaEditada.fact_total);
                    comando.Parameters.AddWithValue("@caje_id", facturaEditada.caje_id);

                    comando.ExecuteNonQuery();
                }

                // Actualizar factura detalle
                string sqlFacturaDetalle = "DELETE FROM factura_detalle WHERE fact_id = @fact_id";
                using (MySqlCommand comando = new MySqlCommand(sqlFacturaDetalle, _contexto))
                {
                    comando.Parameters.AddWithValue("@fact_id", facturaEditada.fact_id);
                    comando.ExecuteNonQuery();
                }
                sqlFacturaDetalle = "INSERT INTO factura_detalle VALUES" +
                    "(@fact_id, @produ_id, @fact_det_cant, @fact_det_prec, @fact_det_total);";
                using (MySqlCommand comando = new MySqlCommand(sqlFacturaDetalle, _contexto))
                {
                    foreach (factura_detalle fact_det in facturaEditada.factura_detalle)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@fact_id", facturaEditada.fact_id);
                        comando.Parameters.AddWithValue("@produ_id", fact_det.produ_id);
                        comando.Parameters.AddWithValue("@fact_det_cant", fact_det.fact_det_cant);
                        comando.Parameters.AddWithValue("@fact_det_prec", fact_det.fact_det_prec);
                        comando.Parameters.AddWithValue("@fact_det_total", fact_det.fact_det_total);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            return resultado;
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
