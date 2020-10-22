﻿using Distribuidora.BL.Entidades;
using Distribuidora.BL.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.BL
{
    public class departamentosBL
    {
        departamentoSQL _departamentoSQL;
        public BindingList<departamento> ListaDepartamentos { get; set; }
        public departamentosBL()
        {
            _departamentoSQL = new departamentoSQL();
        }
        public BindingList<departamento> ObtenerDepartamentos()
        {
            ListaDepartamentos = _departamentoSQL.select();
            return ListaDepartamentos;
        }
    }
}
