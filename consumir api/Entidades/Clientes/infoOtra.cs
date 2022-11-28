using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clientes
{
    public class infoOtra
    {
        #region Atributos

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

        #endregion
    }
}
