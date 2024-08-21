using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Modelos
{
    public class MUsuarios
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public DateAndTime FechaCreacion { get; set; }
        public DateAndTime FechaModificacion { get; set; }

    }
}
