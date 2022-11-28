using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RespuestaLogin
    {
        public serviceRta service { get; set; }
        public resultRta result { get; set; }
        public responseRta response { get; set; }

    }

    public class serviceRta : service
    {
        public string version { get; set; } 
        public string response_data { get; set; }
    }
    public class resultRta
    {
        public int estado { get; set; }
        public string mensaje { get; set; }
    }
    public class responseRta
    {
        public string succes { get; set; }
        public string message { get; set; }
        public dataRta data { get; set; }
    }
    public class dataRta
    {
        public string claveSesion { get; set; }
    }
}
