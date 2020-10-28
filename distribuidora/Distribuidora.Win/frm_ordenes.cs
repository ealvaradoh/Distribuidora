using Distribuidora.BL.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora.Win
{
    public partial class frm_ordenes : Form
    {
        public ordenesBL _ordenesBL;
        public productosBL _productosBL;
        public proveedoresBL _proveedoresBL;
        public frm_ordenes()
        {
            _ordenesBL = new ordenesBL();
            _productosBL = new productosBL();
            _proveedoresBL = new proveedoresBL();
            
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            listaOrdenesBindingSource.DataSource = _ordenesBL.ObtenerOrdenes();
            listaProveedoresBindingSource.DataSource = _proveedoresBL.ObtenerProveedores();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }
    }
}
