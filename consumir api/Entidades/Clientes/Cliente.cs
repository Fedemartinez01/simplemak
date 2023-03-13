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
    public class infoGeneral
    {
        public string idCliente { get; set; }
        public int idEmpresa { get; set; }
        public string NombreFantasia { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string dni { get; set; }
        public string DirPostal { get; set; }
        public string DirPostalCiudad { get; set; }
        public string DirPostalCodigoPostal { get; set; }
        public string DirPostalProvincia { get; set; }
        public string DirPostalPais { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
    public class infoOtra
    {
        public string Activo { get; set; }
        public string FechaAlta { get; set; }
        public string DirFiscal { get; set; }
        public string DirFiscalCiudad { get; set; }
        public string DirFiscalCodigoPostal { get; set; }
        public string DirFiscalProvincia { get; set; }
        public string DirFiscalPais { get; set; }
        public string idCondicionPago { get; set; }
        public string idCondicionIva { get; set; }
        public string porcentajeIVA { get; set; }
        public string idPlanCuenta { get; set; }
        public string CuentaCredito { get; set; }
        public string DirEnvio { get; set; }
        public string DirEnvioCiudad { get; set; }
        public string DirEnvioCodigoPostal { get; set; }
        public string DirEnvioProvincia { get; set; }
        public string DirEnvioPais { get; set; }
    }
}
