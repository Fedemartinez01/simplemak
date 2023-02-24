using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExceptionColppy : Exception
    {
        public ExceptionColppy()
        {

        }
        public ExceptionColppy(string mensaje) : base(mensaje)
        {

        }
        public ExceptionColppy(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
