using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Data
    {
        public int idItem { get; set; }
        public int idEmpresa { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public object detalle { get; set; }
        public string ctaCostoVentas { get; set; }
        public string ctaIngresoVentas { get; set; }
        public string ctaInventario { get; set; }
        public object minimo { get; set; }
        public int costoCalculado { get; set; }
        public int ultimoPrecioCompra { get; set; }
        public int precioVenta { get; set; }
        public string iva { get; set; }
        public string fechaAlta { get; set; }
        public string tipoItem { get; set; }
        public object fechaBaja { get; set; }
        public string unidadMedida { get; set; }
        public object comentarioFactura { get; set; }
        public int esKit { get; set; }
        public string record_insert_ts { get; set; }
        public string record_update_ts { get; set; }
        public int id { get; set; }
    }

    public class Response
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Result
    {
        public int estado { get; set; }
        public string mensaje { get; set; }
    }

    public class RespuestaAltaProducto
    {
        public Service service { get; set; }
        public Result result { get; set; }
        public Response response { get; set; }
    }

    public class Service
    {
        public string provision { get; set; }
        public string operacion { get; set; }
        public string version { get; set; }
        public string response_date { get; set; }
    }


}
