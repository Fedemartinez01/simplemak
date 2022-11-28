using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clientes
{
    public class infoGeneral
    {
        #region Atributos

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

        #endregion
    }
}
