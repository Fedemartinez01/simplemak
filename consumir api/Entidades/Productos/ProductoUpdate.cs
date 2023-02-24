using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{

    public class ProductoUpdate
    {
        public AuthUp_p auth { get; set; }
        public ServiceUp_p service { get; set; }
        public ParametersUp_p parameters { get; set; }

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

        #region Métodos

        public void AsignarCuentas()
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
            #region Region for ctaInventario


            switch (this.parameters.subCategoria.Trim())
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
                    this.parameters.ctaInventario = "115976";
                    break;
                case "Piezas fabricadas por terceros":
                    this.parameters.ctaInventario = "115974";
                    break;
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
                case "1155":
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


        }

        #endregion
    }

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


}
