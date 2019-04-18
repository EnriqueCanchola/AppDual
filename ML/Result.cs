using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {
        public bool Correcto { get; set; }
        public string Mensaje { get; set; }
        public Object Objeto { get; set; }
        public Exception Excepcion { get; set; }
        public List<object> Objetos { get; set; }
    }
}
