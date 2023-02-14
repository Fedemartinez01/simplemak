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
        public parametersProducto parameters { get; set; }

        #endregion
        
        #region Constructor

        public Producto()
        {
            auth = new auth { usuario = "ntraficante@gmail.com", password = "e03c714818c4d45a033b467fa7b76797" };

            service = new service { provision = "Inventario", operacion = "alta_iteminventario" };
        }

        public Producto(string codigo, string descripcion, string subCategoria) : this()
        {
            parameters = new parametersProducto
            {
                sesion = new sesion
                {
                    usuario = "administracion@simplemak.com.ar",
                },

                idEmpresa = 62919,
                codigo = codigo,
                descripcion = descripcion,
                subCategoria = subCategoria,
                detalle = "0",
                minimo = "0",
                ultimoPrecioCompra = "0",
                precioVenta = "0",
                iva = "21",
                tipoItem = "P",
                unidadMedida = "un",
                comentarioFactura = "0"
            };

            AsignarCuentas();
        }
        #endregion

        #region Métodos

        private void AsignarCuentas()
        {
            #region Region for ctaCostoVentas

            int cuentaInventario = Convert.ToInt32(this.parameters.ctaInventario);
            if(cuentaInventario >= 1151 && cuentaInventario <= 1157)
            {
                this.parameters.ctaCostoVentas = "4221";
            }
            else
            {
                this.parameters.ctaCostoVentas = "4211";
            }
            #endregion

            #region Region for ctIngresoVenta

            var cuentaIngresoVenta = this.parameters.ctaInventario;
            switch (cuentaIngresoVenta)
            {
                case "1151":
                    this.parameters.ctaIngresoVentas = "4111";
                    break;
                case "1156":
                    this.parameters.ctaIngresoVentas = "4112";
                    break;
                case "1152":
                case "1153":
                    this.parameters.ctaIngresoVentas = "4113";
                    break;
                case "1157":
                    this.parameters.ctaIngresoVentas = "4114";
                    break;
                case "1155": //errors
                    if(this.parameters.subCategoria.ToLower().Contains("valvu"))
                    {
                        this.parameters.ctaIngresoVentas = "4115";
                    }else if(this.parameters.subCategoria.ToLower().Contains("valvu"))
                    {
                        this.parameters.ctaIngresoVentas = "4115";
                    }
                    break;
                case "1154":
                    this.parameters.ctaIngresoVentas = "4118";
                    break;

                default:
                    this.parameters.ctaIngresoVentas = "4121";
                    break;
            }
            #endregion

            #region Region for ctaInventario


            switch (this.parameters.subCategoria)
            {
                case "Electricidad":
                    this.parameters.ctaInventario = "11591";
                    break;
                case "Hidráulica":
                    this.parameters.ctaInventario = "11592";
                    break;
                case "Materia prima":
                    this.parameters.ctaInventario = "11594";
                    break;
                case "Motores":
                    this.parameters.ctaInventario = "11595";
                    break;
                case "Neumática":
                    this.parameters.ctaInventario = "11596";
                    break;
                case "Rodamientos":
                    this.parameters.ctaInventario = "115910";
                    break;
                case "Transmisión":
                    this.parameters.ctaInventario = "115911";
                    break;
                case "Resortes":
                    this.parameters.ctaInventario = "11598";
                    break;
                case "Varios":
                    this.parameters.ctaInventario = "115912";
                    break;
                case "Buloneria":
                    this.parameters.ctaInventario = "115913";
                    break;
                case "Repuestos importados":
                    this.parameters.ctaInventario = "11599";
                    break;
                case "Conjuntos armados":
                    this.parameters.ctaInventario = "11581";
                    break;
                case "Conjuntos electricidad":
                    this.parameters.ctaInventario = "11582";
                    break;
                case "Conjuntos neumática":
                    this.parameters.ctaInventario = "11584";
                    break;
                case "Conjuntos motores":
                    this.parameters.ctaInventario = "11583";
                    break;
                case "Conjuntos soldados":
                    this.parameters.ctaInventario = "11585";
                    break;
                case "Instrumentos terminados":
                    this.parameters.ctaInventario = "";
                    break;
                case "Insumos y Herramientas":
                    this.parameters.ctaInventario = "115936";
                    break;
                case "Instrumentos conjuntos soldados":
                    this.parameters.ctaInventario = "115931";
                    break;
                case "Instrumentos conjuntos armados":
                    this.parameters.ctaInventario = "";
                    break;
                case "Instrumentos piezas plegadas":
                    this.parameters.ctaInventario = "115934";
                    break;
                case "Instrumentos piezas de revolución":
                    this.parameters.ctaInventario = "";
                    break;
                case "Instrumentos piezas de corte":
                    this.parameters.ctaInventario = "115932";
                    break;
                case "Instrumentos piezas varias":
                    this.parameters.ctaInventario = "115935";
                    break;
                case "Instrumentos piezas estructurales":
                    this.parameters.ctaInventario = "115933";
                    break;
                case "Insumos limpieza":
                    this.parameters.ctaInventario = "";
                    break;
                case "Insumos consumibles":
                    this.parameters.ctaInventario = "";
                    break;
                case "Insumos":
                    this.parameters.ctaInventario = "";
                    break;
                case "Insumos librería":
                    this.parameters.ctaInventario = "42414";
                    break;
                case "Insumos tecnología y computación":
                    this.parameters.ctaInventario = "12231"; //Tambien está 42416
                    break;
                case "Impresoras":
                    this.parameters.ctaInventario = "1156";
                    break;
                case "Prensas":
                    this.parameters.ctaInventario = "1157"; 
                    break;
                case "De Conversión":                 
                    this.parameters.ctaInventario = "1155";
                    break;
                case "Apiladores":
                    this.parameters.ctaInventario = "1151";
                    break;
                case "Accesorios":
                    this.parameters.ctaInventario = "1154";
                    break;
                case "Cortadoras":
                    this.parameters.ctaInventario = "1152";
                    break;
                case "Piezas corte láser":
                    this.parameters.ctaInventario = "115971";
                    break;
                case "Piezas de revolución":
                    this.parameters.ctaInventario = "115972";
                    break;
                case "Piezas estructurales":
                    this.parameters.ctaInventario = "115973";
                    break;
                case "Piezas plegadas":
                    this.parameters.ctaInventario = "115975";
                    break;
                case "Piezas varias - Piezas de fundición":
                    this.parameters.ctaInventario = "";
                    break;
                case "Piezas fabricadas por terceros":
                    this.parameters.ctaInventario = "115974";
                    break;
            }
            #endregion

        }

        #endregion
    }

    public class parametersProducto
    {
        public sesion sesion { get; set; }
        public int idEmpresa { get; set; }
        public string codigo { get; set; }//Code
        public string descripcion { get; set; }//Description
        public string detalle { get; set; }//Observation
        public string minimo { get; set; }//Minimun
        public string ultimoPrecioCompra { get; set; }//Cost?
        public string precioVenta { get; set; }//
        public string ctaInventario { get; set; }//
        public string ctaCostoVentas { get; set; }//
        public string ctaIngresoVentas { get; set; }//
        public string iva { get; set; } //21
        public string tipoItem { get; set; }//"P"
        public string unidadMedida { get; set; }//UnitMeasures
        public string comentarioFactura { get; set; }
        public string subCategoria { get; set; }
    }
}
