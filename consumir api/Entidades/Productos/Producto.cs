using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class Producto
    {
        #region Atributos

        public auth auth { get; set; }
        public service service { get; set; }
        public ParametersProducto parameters { get; set; }


        public int idEmpresa { get; set; }
        public string codigo{ get; set; }//Code
        public string descripcion{ get; set; }//Description
        public string detalle{ get; set; }//Observation
        public decimal minimo { get; set; }//Minimun
        public string ultimoPrecioCompra{ get; set; }//Cost?
        public decimal precioVenta{ get; set; }//
        public string ctaInventario { get; set; }//
        public string ctaCostoVentas { get; set; }//
        public string ctaIngresoVentas { get; set; }//
        public string iva { get; set; } //21
        public string tipoItem { get; set; }//"P"
        public string unidadMedida { get; set; }//UnitMeasures
        public string comentarioFactura { get; set; }

        #endregion
        #region Constructor

        Producto()
        {
            auth = new auth { usuario = "ntraficante@gmail.com", password = "e03c714818c4d45a033b467fa7b76797" };

            service = new service { provision = "Cliente", operacion = "alta_cliente" };
        }


        #endregion
    }

    public class ParametersProducto
    {
        public sesion sesion { get; set; }
    }
}
