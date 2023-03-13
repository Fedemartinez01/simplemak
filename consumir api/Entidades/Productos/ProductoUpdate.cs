using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{

    public class ProductoUpdate
    {
        #region Atributos

        public AuthUp_p auth { get; set; }
        public ServiceUp_p service { get; set; }
        public ParametersUp_p parameters { get; set; }
        #endregion

        #region Constructor

        public ProductoUpdate()
        {
            auth = new AuthUp_p { usuario = "ntraficante@gmail.com", password = "e03c714818c4d45a033b467fa7b76797" };

            service = new ServiceUp_p { provision = "Inventario", operacion = "editar_iteminventario" };
        }

        public ProductoUpdate(string codigo, string descripcion, string subCategoria, string idColppy) : this()
        {
            parameters = new ParametersUp_p
            {
                sesion = new SesionUp_p
                {
                    usuario = "administracion@simplemak.com.ar",
                },

                idEmpresa = "62919",
                idItem = idColppy,
                id = idColppy,
                codigo = codigo,
                descripcion = descripcion,
                subCategoria = subCategoria,
                detalle = "0",
                minimo = "0",
                precioVenta = "0",
                iva = "21",
                tipoItem = "P",
                unidadMedida = "un",
                ultimoPrecioCompra = "0",
            };

             AsignarCuentas();
        }
        #endregion

        #region Métodos

        public void AsignarCuentas()
        {
            #region Region for ctaInventario

            string ctaInvetario = "";

            switch (this.parameters.subCategoria.Trim())
            {
                case "Instrumentos conjuntos armados":
                    ctaInvetario = "INST CONJUNTOS ARMADOS";
                    //HAY QUE PROBAR EN PRODUCCION
                    break;

                case "Instrumentos piezas de revolución":
                    ctaInvetario = "INST PIEZAS DE REVOLUCION";
                    //HAY QUE PROBAR EN PRODUCCION
                    break;

                case "Instrumentos terminados":
                    ctaInvetario = "INST TERMINADOS";
                    //HAY QUE PROBAR EN PRODUCCION
                    break;

                case "Instrumentos conjuntos soldados":
                    ctaInvetario = "INST CONJUNTOS SOLDADOS";
                    break;

                case "Piezas varias-Piezas de fundición":
                    ctaInvetario = "PIEZAS VARIAS FUNDICION";
                    break;

                case "Instrumentos piezas de corte":
                    ctaInvetario = "INSTR PIEZAS DE CORTE";
                    break;

                case "Instrumentos piezas estructurales":
                    ctaInvetario = "INSTR PIEZAS ESTRUCTURALES";
                    break;

                case "Instrumentos piezas plegadas":
                    ctaInvetario = "INSTR PIEZAS PLEGADAS";
                    break;

                case "Instrumentos piezas varias":
                    ctaInvetario = "INSTR PIEZAS VARIAS";
                    break;

                case "Motores":
                    ctaInvetario = "MOTOR";
                    break;

                case "Insumos consumibles":
                case "Insumos librería":
                case "Insumos limpieza":
                case "Insumos tecnología y computación":
                    ctaInvetario = "INSUMOS VARIOS";
                    break;

                default:
                    ctaInvetario = this.parameters.subCategoria.ToUpper().Trim();
                    break;
            }

            this.parameters.ctaInventario = ctaInvetario;

            #endregion

            #region Region for ctaCostoVentas

            var cuentaInventario = this.parameters.ctaInventario;
            switch (cuentaInventario)
            {
                case "APILADORES":
                case "CORTADORAS":
                case "ACCESORIOS":
                case "DE CONVERSIÓN":
                case "IMPRESORAS":
                case "PRENSAS":
                    this.parameters.ctaCostoVentas = "COSTO DE VENTA MAQUINAS";
                    break;

                default:
                    this.parameters.ctaCostoVentas = "COMPRAS INSUMOS";
                    break;
            }
            #endregion

            #region Region for ctIngresoVenta
            var cuentaIngresoVenta = this.parameters.ctaInventario;
            switch (cuentaIngresoVenta)
            {
                case "APILADORES":
                    this.parameters.ctaIngresoVentas = "VENTA DE APILADORES";
                    break;
                case "IMPRESORAS":
                    this.parameters.ctaIngresoVentas = "VENTA DE IMPRESORAS";
                    break;
                case "CORTADORAS":
                    this.parameters.ctaIngresoVentas = "VENTA DE CORTADORAS";
                    break;
                case "PRENSAS":
                    this.parameters.ctaIngresoVentas = "VENTA DE PRENSAS";
                    break;
                case "VALVULADORAS":
                    if (this.parameters.subCategoria.ToLower().Contains("valvu"))
                    {
                        this.parameters.ctaIngresoVentas = "VENTA DE VALVULADORAS";
                    }
                    break;
                case "ACCESORIOS":
                    this.parameters.ctaIngresoVentas = "VENTA DE OTRAS MAQUINARIAS";
                    break;

                default:
                    this.parameters.ctaIngresoVentas = "VENTA DE REPUESTOS";
                    break;
            }
            #endregion
        }

        #endregion
    }

    #region Clases de p_u

    public class AuthUp_p
    {
        public string usuario { get; set; }
        public string password { get; set; }
    }

    public class ParametersUp_p
    {
        public SesionUp_p sesion { get; set; }
        public string idEmpresa { get; set; }
        public string idItem { get; set; }
        public string id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string detalle { get; set; }
        public string minimo { get; set; }
        public string precioVenta { get; set; }
        public string ctaInventario { get; set; }
        public string ctaCostoVentas { get; set; }
        public string ctaIngresoVentas { get; set; }
        public string iva { get; set; }
        public string tipoItem { get; set; }
        public string unidadMedida { get; set; }
        public string ultimoPrecioCompra { get; set; }
        public string subCategoria { get; set; }

    }

    public class ServiceUp_p
    {
        public string provision { get; set; }
        public string operacion { get; set; }
    }

    public class SesionUp_p
    {
        public string usuario { get; set; }
        public string claveSesion { get; set; }
    }
    #endregion


}
