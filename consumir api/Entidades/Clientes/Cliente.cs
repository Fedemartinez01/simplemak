using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clientes
{
    public class Cliente
    {
        #region Constructor


        public Cliente()
        {
            auth = new auth { usuario = "ntraficante@gmail.com", password = "e03c714818c4d45a033b467fa7b76797" };

            service = new service { provision = "Cliente", operacion = "alta_cliente" };

        }

        public Cliente(string nombreFantasia, string razonSocial, string cuit, string dniNumero, string direcion, string ciudad, string codigoPostal, string provincia, string pais, string telefono, string email, string activo, string fechaAlta) : this()
        {


            parameters = new parametersCLiente
            {

                sesion = new sesion
                {
                    usuario = "administracion@simplemak.com.ar",
                },

                info_general = new infoGeneral
                {
                    idCliente = String.Empty,
                    idEmpresa = 62919,
                    NombreFantasia = nombreFantasia,
                    RazonSocial = razonSocial,
                    CUIT = cuit,
                    dni = dniNumero,
                    DirPostal = direcion,
                    DirPostalCiudad = ciudad,
                    DirPostalCodigoPostal = codigoPostal,
                    DirPostalProvincia = String.Empty,
                    DirPostalPais = pais,
                    Telefono = telefono,
                    Email = email
                },

                info_otra = new infoOtra
                {
                    Activo = activo,
                    FechaAlta = String.Empty,
                    DirFiscal = String.Empty,
                    DirFiscalCiudad = String.Empty,
                    DirFiscalCodigoPostal = String.Empty,
                    DirFiscalProvincia = String.Empty,
                    DirFiscalPais = String.Empty,
                    idCondicionPago = String.Empty,
                    idCondicionIva = String.Empty,
                    porcentajeIVA = String.Empty,
                    idPlanCuenta = String.Empty,
                    CuentaCredito = String.Empty,
                    DirEnvio = String.Empty,
                    DirEnvioCiudad = String.Empty,
                    DirEnvioCodigoPostal = String.Empty,
                    DirEnvioProvincia = String.Empty,
                    DirEnvioPais = String.Empty,
                }    
            };
        }

        #endregion

        #region Atributos

        public auth auth { get; set; }
        public service service { get; set; }
        public parametersCLiente parameters { get; set; }

        #endregion

        #region Métodos

        public void AsignarCUITGenerico(string pais)
        {

            switch (pais)
            {
                case "ALBANIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.ALBANIA).ToString();
                    break;
                case "ARGENTINA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.ARGENTINA).ToString();
                    break;
                case "BOLIVIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.BOLIVIA).ToString();
                    break;
                case "BRASIL":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.BRASIL).ToString();
                    break;
                case "CHILE":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.CHILE).ToString();
                    break;
                case "COLOMBIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.COLOMBIA).ToString();
                    break;
                case "COSTA RICA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.COSTARICA).ToString();
                    break;
                case "CUBA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.CUBA).ToString();
                    break;
                case "ECUADOR":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.ECUADOR).ToString();
                    break;
                case "EL SALVADOR":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.ELSALVADOR).ToString();
                    break;
                case "EMIRATOS ARABES,UNID":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.EMIRATOSARABES).ToString();
                    break;
                case "ESPAÑA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.ESPAÑA).ToString();
                    break;
                case "GUATEMALA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.GUATEMALA).ToString();
                    break;
                case "HONDURAS":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.HONDURAS).ToString();
                    break;
                case "INDIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.INDIA).ToString();
                    break;
                case "JORDANIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.JORDANIA).ToString();
                    break;
                case "MEXICO":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.MEXICO).ToString();
                    break;
                case "PANAMA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.PANAMA).ToString();
                    break;
                case "PARAGUAY":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.PARAGUAY).ToString();
                    break;
                case "PERU":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.PERU).ToString();
                    break;
                case "POLONIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.POLONIA).ToString();
                    break;
                case "RUMANIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.RUMANIA).ToString();
                    break;
                case "RUSIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.RUSIA).ToString();
                    break;
                case "SUDAFRICA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.SUDAFRICA).ToString();
                    break;
                case "TURQUIA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.TURQUIA).ToString();
                    break;
                case "URUGUAY":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.URUGUAY).ToString();
                    break;
                case "VENEZUELA":
                    this.parameters.info_general.CUIT = Convert.ToDecimal(CUITGenerico.VENEZUELA).ToString();
                    break;
                default:
                    this.parameters.info_general.CUIT = "0";
                    break;
            }
        }

        #endregion
    }
    public class parametersCLiente
    {
        public sesion sesion { get; set; }
        public infoGeneral info_general { get; set; }
        public infoOtra info_otra { get; set; }
    }
    public enum CUITGenerico : long
    {
        ALBANIA = 50000004011,
        ARGENTINA = 50000002000,
        BOLIVIA = 50000000040,
        BRASIL = 50000000059,
        CHILE = 50000000032,
        COLOMBIA = 50000002051,
        COSTARICA = 50000001586,
        CUBA = 50000002396,
        ECUADOR = 50000002426,
        ELSALVADOR = 50000002116,
        EMIRATOSARABES = 50000003317,
        ESPAÑA = 50000004100,
        GUATEMALA = 50000002132,
        HONDURAS = 50000002167,
        INDIA = 50000003155,
        JORDANIA = 50000003007,
        MEXICO = 50000002183,
        PANAMA = 50000002205,
        PARAGUAY = 50000000024,
        PERU = 50000002221,
        POLONIA = 50000004240,
        RUMANIA = 50000004275,
        RUSIA = 0,
        SUDAFRICA = 50000001713,
        TURQUIA = 50000003503,
        URUGUAY = 50000000016,
        VENEZUELA = 50000002264
    }

}
