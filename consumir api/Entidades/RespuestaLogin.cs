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

    public class Rta
    {
        public serviceRta Service { get; set; }
        public resultRta Result { get; set; }
        public AllresponseRta Response { get; set; }

    }

    public class AllDataRta
    {
        public string idItem { get; set; }
        public string idEmpresa { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string detalle { get; set; }
        public string ctaCostoVentas { get; set; }
        public string ctaIngresoVentas { get; set; }
        public string ctaInventario { get; set; }
        public string minimo { get; set; }
        public string costoCalculado { get; set; }
        public string ultimoPrecioCompra { get; set; }
        public string precioVenta { get; set; }
        public string iva { get; set; }
        public string fechaAlta { get; set; }
        public string tipoItem { get; set; }
        public string fechaBaja { get; set; }
        public string unidadMedida { get; set; }
        public string comentarioFactura { get; set; }
        public string esKit { get; set; }
        public string record_insert_ts { get; set; }
        public string record_update_ts { get; set; }
        public string id { get; set; }
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
    public class AllresponseRta
    {
        public string succes { get; set; }
        public string message { get; set; }
        public AllDataRta data { get; set; }
    }
    public class dataRta
    {
        public string claveSesion { get; set; }
    }
}
