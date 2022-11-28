using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clientes
{
    public class ClienteSQL
    {
        #region Atributos

        string connectionString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;

        #endregion

        #region Constructor

        public ClienteSQL()
        {
            connectionString = "Data Source=.;Initial Catalog=SystemERP_DB;Integrated Security=True";
            sqlCommand = new SqlCommand();
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }

        #endregion

        #region Métodos

        public List<Cliente> LeerBaseDeDatos()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                sqlConnection.Open();
                Console.WriteLine("--- Conexion abierta ---");

                sqlCommand.CommandText = "\r\nselect c.Id, c.BusinessName, c.BusinessName, d.Description, c.DocumentNumber, c.Address, \r\nci.Name, c.PostalCode, st.Name, co.Denomination, c.CellPhoneNumber, c.Email, c.IsActive, c.CreatedOn\r\nfrom Clients c\r\nleft join DocumentTypes d\r\non c.DocumentTypeId = d.Id\r\nleft join Cities ci\r\non c.CityId = ci.Id\r\nleft join States st\r\non c.StateId = st.Id\r\nleft join Countries co\r\non c.CountryId = co.Id where c.IsOnColppy = 0";

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string isActive = "0";
                        string TipoDocumento = dataReader["Description"].ToString();
                        string NumeroDocumento = dataReader["DocumentNumber"].ToString();
                        string Pais = dataReader["Denomination"].ToString();

                        if (dataReader["IsActive"].ToString() == "True")
                        {
                            isActive = "1";
                        }

                        try
                        {
                           Cliente cliente = new Cliente(
                           dataReader["BusinessName"].ToString(),
                           dataReader["BusinessName"].ToString(),
                           string.Empty,
                           string.Empty,
                           dataReader["Address"].ToString(),
                           dataReader["Name"].ToString(),
                           dataReader["PostalCode"].ToString(),
                           dataReader["Name"].ToString(),
                           Pais,
                           dataReader["CellPhoneNumber"].ToString(),
                           dataReader["Email"].ToString(),
                           isActive,
                          string.Empty
                            );

                            if(NumeroDocumento != String.Empty)
                            {
                                if(TipoDocumento == "CUIT")
                                {
                                    cliente.parameters.info_general.CUIT = NumeroDocumento;
                                }
                                else 
                                {
                                    cliente.parameters.info_general.dni = NumeroDocumento;
                                }
                            }
                            else
                            {
                                cliente.AsignarCUITGenerico(Pais);
                            }

                            clientes.Add(cliente);
                                
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                    }
                }
                return clientes;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        #endregion
    }
}
