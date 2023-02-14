using System;
using System.Collections.Generic;
using System.Data;
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

                sqlCommand.CommandText = "select c.Id, c.BusinessName, c.BusinessName, d.Description, c.DocumentNumber, c.Address,  ci.Name, c.PostalCode, st.Name, co.Denomination, c.CellPhoneNumber, c.Email, c.IsActive, c.CreatedOn, c.IsOnColppy from Clients c left join DocumentTypes d on c.DocumentTypeId = d.Id left join Cities ci on c.CityId = ci.Id left join States st on c.StateId = st.Id left join Countries co on c.CountryId = co.Id";

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string isActive = "0";
                        string TipoDocumento = dataReader["Description"].ToString();
                        string NumeroDocumento = dataReader["DocumentNumber"].ToString();
                        string Pais = dataReader["Denomination"].ToString();
                        string IsOnColppy = dataReader["IsOnColppy"].ToString();

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
                            cliente.AsignarDocumentNumber(TipoDocumento, NumeroDocumento);
                            cliente.DefinirOperacionAltaOEditar(IsOnColppy);

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

        /// <summary>
        /// Cuando el cliende es dado de alta, se cambia el estado de colppy a 1 en la base de datos
        /// </summary>
        /// <param name="NombreFantasia"></param>
        public void CambiarEstadoColppy(string NombreFantasia)
        {
            var isOk = 0;
            try
            {
                sqlConnection.Open();
                Console.WriteLine("--- Conexion abierta ---");

                sqlCommand.CommandText = $"UPDATE Clients SET IsOnColppy = 1 where BusinessName like @NombreFantasia";
                sqlCommand.Parameters.AddWithValue("@NombreFantasia", NombreFantasia);
                isOk = sqlCommand.ExecuteNonQuery();

                if (isOk == 1)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        #endregion
    }
}
