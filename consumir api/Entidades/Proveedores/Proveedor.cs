using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Proveedores
{
    public class Proveedor
    {
        #region Atributos

        public auth auth { get; set; }
        public service service { get; set; }
        public parametersProveedor parameters { get; set; }

        #endregion

        #region Constructor

        public Proveedor()
        {
            auth = new auth { usuario = "ntraficante@gmail.com", password = "e03c714818c4d45a033b467fa7b76797" };

            service = new service { provision = "Proveedor", operacion = "alta_proveedor" };

        }
        public Proveedor(string razonSocial, string nombreFantasia, string dirPostal, string dirPostalCiudad, string dirPostalCodigoPostal, string dirPostalProvincia, string dirPostalPais, string cUIT, string idUsuario, string activo, string idCondicionIva):this()
        {
            parameters = new parametersProveedor
            {
                sesion = new sesion
                {
                    usuario = "administracion@simplemak.com.ar",
                },

                idEmpresa = 62919,
                RazonSocial = razonSocial,
                NombreFantasia = nombreFantasia,
                DirPostal = dirPostal,
                DirPostalCiudad = dirPostalCiudad,
                DirPostalCodigoPostal = dirPostalCodigoPostal,
                DirPostalProvincia = dirPostalProvincia,
                DirPostalPais = dirPostalPais,
                Telefono = String.Empty,
                CUIT = cUIT,
                idUsuario = idUsuario,
                Email = String.Empty,
                Activo = activo,
                FechaAlta = String.Empty,
                DirFiscal = String.Empty,
                DirFiscalCiudad = String.Empty,
                DirFiscalCodigoPostal = String.Empty,
                DirFiscalProvincia = String.Empty,
                DirFiscalPais = String.Empty,
                Banco = String.Empty,
                CBU = String.Empty,
                Producto = String.Empty,
                idCondicionPago = String.Empty,
                idCondicionIva = idCondicionIva,
                porcentajeIVA = "21",
                idTipoPercepcion = String.Empty,
                idRetGanancias = String.Empty,
                idPlanCuenta = String.Empty,
            };
        }

        #endregion
    }

    public class parametersProveedor
    {

        public sesion sesion { get; set; }
        public int idEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string NombreFantasia { get; set; }
        public string DirPostal { get; set; }
        public string DirPostalCiudad { get; set; }
        public string DirPostalCodigoPostal { get; set; }
        public string DirPostalProvincia { get; set; }
        public string DirPostalPais { get; set; }
        public string Telefono { get; set; }
        public string CUIT { get; set; }
        public string idUsuario { get; set; }
        public string Email { get; set; }
        public string Activo { get; set; }
        public string FechaAlta { get; set; }
        public string DirFiscal { get; set; }
        public string DirFiscalCiudad { get; set; }
        public string DirFiscalCodigoPostal { get; set; }
        public string DirFiscalProvincia { get; set; }
        public string DirFiscalPais { get; set; }
        public string Banco { get; set; }
        public string CBU { get; set; }
        public string Producto { get; set; }
        public string idCondicionPago { get; set; }
        public string idCondicionIva { get; set; }
        public string porcentajeIVA { get; set; }
        public string idTipoPercepcion { get; set; }
        public string idRetGanancias { get; set; }
        public string idPlanCuenta { get; set; }


    }
}
