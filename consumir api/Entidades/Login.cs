using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {       
        public auth auth { get; set; }
        public service service { get; set; }
        public parameters parameters { get; set; }

    }
    public class auth
    {
        public string usuario { get; set; }
        public string password { get; set; }
    }
    public class service
    {
        public string provision { get; set; }
        public string operacion { get; set; }
    }
    public class parameters
    {
        public string usuario { get; set; }
        public string password { get; set; }
    }
    public class sesion
    {
        public string usuario { get; set; }
        public string claveSesion { get; set; }
    }
}
