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


        Cliente()
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

        /// <summary>
        /// Lee si el cliente está dado de alta en Colppy, si está hace un editar_cliente si no está hace un alta_cliente
        /// </summary>
        /// <param name="IsOnColppy"></param>
        public void DefinirOperacionAltaOEditar(string IsOnColppy)
        {
            if (IsOnColppy == "1")
            {
                this.service.operacion = "alta_cliente";
            }
            else
            {
                this.service.operacion = "editar_cliente";
            }
        }
        /// <summary>
        /// Lee si el cliente tiene asignado un documento tipo DNI u otro.. si es dni lo guarda en el dni, si es otro lo guarda en CUIT
        /// </summary>
        /// <param name="tipoDni"></param>
        /// <param name="numeroDni"></param>
        public void AsignarDocumentNumber(string tipoDni, string numeroDni)
        {
            if(tipoDni == "DNI")
            {
                this.parameters.info_general.dni= numeroDni;
            }
            else
            {
                this.parameters.info_general.CUIT = numeroDni;
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

}
