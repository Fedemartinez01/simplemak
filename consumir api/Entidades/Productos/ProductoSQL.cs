using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class ProductoSQL
    {
        #region Atributos

        string connectionString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;

        #endregion

        #region Constructor

        public ProductoSQL()
        {
            connectionString = "Data Source=.;Initial Catalog=SystemERP_DB;Integrated Security=True";
            sqlCommand = new SqlCommand();
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }

        #endregion

        #region Metodos


        public List<Producto> LeerBaseDeDatos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                sqlConnection.Open();
                Console.WriteLine("--- Conexion abierta ---");

                sqlCommand.CommandText = "select * from Products";

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        

                        try
                        {

                            //Producto producto = new Producto();

                            //productos.Add(producto);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                    }
                }
                return productos;
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
