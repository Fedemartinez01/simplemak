using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExceptionEntidadNull : Exception
    {
        public ExceptionEntidadNull()
        {

        }
        public ExceptionEntidadNull(string mensaje) : base(mensaje)
        {

        }
        public ExceptionEntidadNull(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
