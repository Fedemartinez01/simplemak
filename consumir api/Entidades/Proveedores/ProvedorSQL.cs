using Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Proveedores
{
    public class ProvedorSQL
    {
        #region Atributos


        string connectionString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;

        #endregion
        public ProvedorSQL()
        {
            connectionString = "Data Source=.;Initial Catalog=SystemERP_DB;Integrated Security=True";
            sqlCommand = new SqlCommand();
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }
        public List<Proveedor> LeerBaseDeDatos()
        {
            List<Proveedor> proveedores= new List<Proveedor>();
            try
            {
                sqlConnection.Open();
                Console.WriteLine("--- Conexion abierta ---");

                sqlCommand.CommandText = "SELECT p.BusinessName, p.BusinessName, p.Address, cit.Name, p.PostalCode,\r\nsta.Name, cou.Denomination, p.DocumentNumber, p.Id, p.IsActive, p.IVAConditionId\r\nFROM Providers p\r\nleft join Cities cit on cit.Id = p.CityId\r\nleft join States sta on sta.Id = p.StateId\r\nleft join Countries cou on cou.Id = p.CountryId\r\nwhere BusinessName is not null and DocumentNumber is not null\r\n";

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string isActive = "0";

                        if (dataReader["IsActive"].ToString() == "True")
                        {
                            isActive = "1";
                        }

                        try
                        {
                            Proveedor proveedor = new Proveedor(
                            dataReader["BusinessName"].ToString(),
                            dataReader["BusinessName"].ToString(),
                            dataReader["Address"].ToString(),
                            dataReader["Name"].ToString(),
                            dataReader["PostalCode"].ToString(),
                            dataReader["Name"].ToString(),
                            dataReader["Denomination"].ToString(),
                            dataReader["DocumentNumber"].ToString(),
                            dataReader["Id"].ToString(),
                            isActive,
                            dataReader["IVAConditionId"].ToString()
                             );

                            proveedores.Add(proveedor);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                    }
                }
                return proveedores;
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
    }
}
