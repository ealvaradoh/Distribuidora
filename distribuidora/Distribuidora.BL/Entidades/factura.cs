﻿    using Distribuidora.BL.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.Entidades
{
    public class factura
    {
        public int fact_id { get; set; }
        public DateTime fact_fecha { get; set; }
        public int clien_id { get; set; }
        public cliente cliente { get; set; }
        public decimal fact_subt { get; set; }
        public decimal fact_isv { get; set; }
        public decimal fact_total { get; set; }
        public int caje_id { get; set; }
        public cajero cajero { get; set; }
        public BindingList<factura_detalle> factura_detalle { get; set; }

        public factura()
        {
            fact_fecha = DateTime.Now;
            factura_detalle = new BindingList<factura_detalle>();

            fact_subt = 0;
            fact_isv = 0;
            fact_total = 0;
        }

        
    }

    public class factura_detalle
    {
        public int fact_id { get; set; }
        public factura factura { get; set; }
        public int produ_id { get; set; }
        public producto producto { get; set; }
        public decimal fact_det_cant { get; set; }
        public decimal fact_det_prec { get; set; }
        public decimal fact_det_total { get; set; }

        public factura_detalle()
        {
            produ_id = 1;
            fact_det_cant = 1;
        }
    }
}
