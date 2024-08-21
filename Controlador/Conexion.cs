using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Controlador
{
    public class Conexion
    {
        private string server = ".";
        private string database = "streaming";
        public static string cn = @"Server=.;Database=streaming;Integrated Security=true";
    }
}
