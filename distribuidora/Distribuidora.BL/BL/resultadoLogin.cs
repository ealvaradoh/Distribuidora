using Distribuidora.BL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.BL.BL
{
    public class resultadoLogin
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

        public static int empleadoID;
        public static string empleadoNumeroID;
        public static string empleadoNombre;
        public static string empleadoMail;
        public static string empleadoMailContra;
        public static int departamentoID;
        public static string departamentoNombre;
        public static bool departamentoControlTotal;
        public static int cajeroID;
    }
}
