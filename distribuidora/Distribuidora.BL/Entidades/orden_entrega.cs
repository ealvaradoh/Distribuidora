using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.Entidades
{
    public class orden_entrega
    {
        public int ord_id { get; set; }
        public DateTime ord_fecha { get; set; }
        public decimal ord_cant_produ { get; set; }
        public int prov_id { get; set; }
        public proveedor proveedor { get; set; }
        public BindingList<orden_detalle> orden_detalle { get; set; }

        public orden_entrega()
        {
            ord_fecha = DateTime.Now;
            orden_detalle = new BindingList<orden_detalle>();
        }
    }

    public class orden_detalle
    {
        public int ord_det_id { get; set; }
        public int ord_id { get; set; }
        public int produ_id { get; set; }
        public producto producto { get; set; }
        public decimal ord_det_cant { get; set; }

    }
}
