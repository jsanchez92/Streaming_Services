using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming.Contratos
{
    public interface IContrato<T>
    {
        public string Add(T obj);
        public string Update(T obj);
        public string Delete(int id);
        public DataTable Buscar(string Texto);
    }
}
