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
        public string codigo{ get; set; }
        public string descripcion{ get; set; }
        public string detalle{ get; set; }//observation
        public decimal minimo { get; set; }//minimun
        public string ultimoPrecioCompra{ get; set; }//cost?
        public decimal precioVenta{ get; set; }//
        public string ctaInventario { get; set; }//
        public string ctaCostoVentas { get; set; }//
        public string ctaIngresoVentas { get; set; }//
        public string iva { get; set; } //21
        public string tipoItem { get; set; }//
        public string unidadMedida { get; set; }//UnitMeasures
        public string comentarioFactura { get; set; }

        #endregion
    }

    public class ParametersProducto
    {
        public sesion sesion { get; set; }
    }
}
