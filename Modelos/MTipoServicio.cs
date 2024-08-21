using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Modelos
{
    public class MTipoServicio
    {
        public int Id { get; set; }
        public int ServiciosID { get; set; }
        public string Tipo { get; set; }
        public int Costo { get; set; }
        public int Cant_Dispositivos { get; set; }
        public DateAndTime FechaCreacion { get; set; }
        public DateAndTime FechaModificacion { get; set; }
    }
}
