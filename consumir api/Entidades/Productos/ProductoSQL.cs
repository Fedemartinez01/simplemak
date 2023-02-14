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

                //sqlCommand.CommandText = "select p.Code, p.Description, s.Description as Subcategoria from Products p inner join UnitMeasures um on um.Id = p.UnitMeasureId inner join SubCategories s on s.Id = p.SubCategoryId order by p.LastModifiedOn desc";

                sqlCommand.CommandText = "select p.Code, p.Description, s.Description as Subcategoria from Products p inner join UnitMeasures um on um.Id = p.UnitMeasureId inner join SubCategories s on s.Id = p.SubCategoryId where p.IsOnColppy = 0 order by p.LastModifiedOn desc";

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string codigo = dataReader["Code"].ToString();
                        string descripcion = dataReader["Description"].ToString();
                        string subCatergoria = dataReader["Subcategoria"].ToString();

                        try
                        {
                            Producto producto = new Producto(codigo, descripcion, subCatergoria);
                            productos.Add(producto);

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
        
        public List<Producto> LeerBaseDeDatosPorFecha(string fechaInicio, string fechaFin)
        {
            List<Producto> productos = new List<Producto>();
            try
            {

                sqlConnection.Open();
                Console.WriteLine("--- Conexion abierta ---");

                sqlCommand.CommandText = "select p.Code, p.Description, s.Description as Subcategoria from Products p inner join UnitMeasures um on um.Id = p.UnitMeasureId inner join SubCategories s on s.Id = p.SubCategoryId where p.LastModifiedOn between @FechaInicio and @FechaFin order by p.LastModifiedOn desc";
                sqlCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                sqlCommand.Parameters.AddWithValue("@FechaFin", fechaFin);

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string codigo = dataReader["Code"].ToString();
                        string descripcion = dataReader["Description"].ToString();
                        string subCatergoria = dataReader["Subcategoria"].ToString();

                        try
                        {
                            Producto producto = new Producto(codigo, descripcion, subCatergoria);
                            productos.Add(producto);

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

        public void CambiarEstadoColppy(string Code)
        {
            var isOk = 0;
            try
            {
                sqlConnection.Open();
                Console.WriteLine("--- Conexion abierta ---");

                sqlCommand.CommandText = $"UPDATE Products SET IsOnColppy = 1 where Code like @Code";
                sqlCommand.Parameters.AddWithValue("@Code", Code);
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
