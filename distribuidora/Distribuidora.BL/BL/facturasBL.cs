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
                string sqlFactura = "Select * from factura";
                using (MySqlCommand comando = new MySqlCommand(sqlFactura, _contexto))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        factura fact;
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
                    }
                    foreach (var factura in ListaFacturas)
                    {
                        AsignarDetalle(factura);
                    }
                    return ListaFacturas;
                }

                void AsignarDetalle(factura factura)
                {
                    string sqlFacturaDetalle = "SELECT * FROM factura_detalle " +
                            "WHERE fact_id = @fact_id";
                    using (MySqlCommand comando = new MySqlCommand(sqlFacturaDetalle, _contexto))
                    {
                        comando.Parameters.AddWithValue("@fact_id", factura.fact_id);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            factura_detalle fact_det;
                            while (reader.Read())
                            {
                                fact_det = new factura_detalle();
                                fact_det.fact_id = int.Parse(reader["fact_id"].ToString());
                                fact_det.produ_id = int.Parse(reader["produ_id"].ToString());
                                fact_det.fact_det_cant = decimal.Parse(reader["fact_det_cant"].ToString());
                                fact_det.fact_det_prec = decimal.Parse(reader["fact_det_prec"].ToString());
                                fact_det.fact_det_total = decimal.Parse(reader["fact_det_total"].ToString());

                                factura.factura_detalle.Add(fact_det);
                            }
                            reader.Close();
                        }
                    }
                }
            }
        }

        
        public void EliminarFactura(factura factura)
        {
            MySqlConnection _contexto;
            using (_contexto = contexto.crearConexion())
            {
                string sqlFacturaDetalle = "DELETE FROM factura_detalle WHERE fact_id = @fact_id";
                using (MySqlCommand comando = new MySqlCommand(sqlFacturaDetalle, _contexto))
                {
                    comando.Parameters.AddWithValue("@fact_id", factura.fact_id);
                    comando.ExecuteNonQuery();
                }

                string sqlfactura = "DELETE FROM factura WHERE fact_id = @fact_id";
                using (MySqlCommand comando = new MySqlCommand(sqlfactura, _contexto))
                {
                    comando.Parameters.AddWithValue("@fact_id", factura.fact_id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public resultado AutorizaCajeroAtiende(factura factura)
        {
            var resultado = new resultado();
            resultado.Exitoso = true;

            MySqlConnection _contexto;
            string sql = "SELECT emp.`emp_id`, caje.`caje_id` " +
                    "FROM empleado emp, cajero caje " +
                    "WHERE emp.`emp_id` = caje.`emp_id` AND emp.`emp_mail` = @mail;";
            using (_contexto = contexto.crearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                {
                    comando.Parameters.AddWithValue("@mail", resultadoLogin.empleadoMail);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            factura.caje_id = int.Parse(reader["caje_id"].ToString());
                        }
                        if (!reader.HasRows)
                        {
                            resultado.Exitoso = false;
                            resultado.Mensaje = "El empleado no está autorizado para hacer facturas";
                        }
                    }
                }
                return resultado;
            }
        }

        public void CalcularTotalGeneral(factura fact)
        {
            var productoBL = new productosBL();

            decimal subtotal = 0;
            foreach (var fact_det in fact.factura_detalle)
            {
                var precio = productoBL.ObtenerPrecio(fact_det.produ_id);
                subtotal += CalcularTotalDetalle(fact_det, precio);
            }

            fact.fact_subt = subtotal;
            fact.fact_isv = fact.fact_subt * decimal.Parse("0.15");
            fact.fact_total = fact.fact_subt + fact.fact_isv;
        }

        public decimal CalcularTotalDetalle(factura_detalle fact_det, decimal precio)
        {
            fact_det.fact_det_prec = precio;

            fact_det.fact_det_total =
                fact_det.fact_det_cant * fact_det.fact_det_prec;

            return fact_det.fact_det_total;
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
            ListaFacturasDetalle.Clear();
            resultado.Mensaje = "Guardado exitósamente";
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
            resultado.Mensaje = "Guardado exitósamente";
            return resultado;
        }

        public resultado AgregarFactura()
        {
            var nuevaFactura = new factura();
            var resultado = AutorizaCajeroAtiende(nuevaFactura);

            if (resultado.Exitoso == false)
                return resultado;
            else
            {
                MySqlConnection _contexto;
                using (_contexto = contexto.crearConexion())
                {
                    string sql = "SELECT emp.`emp_id`, caje.`caje_id`" +
                        "FROM empleado emp, cajero caje " +
                        "WHERE emp.`emp_id` = caje.`emp_id` " +
                        "AND emp_mail = @mail;";
                    using (MySqlCommand comando = new MySqlCommand(sql, _contexto))
                    {
                        comando.Parameters.AddWithValue("@mail", resultadoLogin.empleadoMail);
                        MySqlDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            nuevaFactura.caje_id = int.Parse(reader["caje_id"].ToString());
                        }
                        reader.Close();
                    }
                    ListaFacturas.Add(nuevaFactura);
                }
            }

            return resultado;
        }

        public void AgregarFacturaDetalle(factura factura)
        {
            if (factura != null)
            {
                var nuevoDetalle = new factura_detalle();
                factura.factura_detalle.Add(nuevoDetalle);
                //ListaFacturasDetalle.Add(nuevoDetalle);
            }
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
