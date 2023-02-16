using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class ProductoSQL
    {
        #region Atributos

        private SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=SystemERP_DB;Integrated Security=True");

        #endregion

        #region Constructor

        public ProductoSQL()
        {

        }

        #endregion

        #region Metodos


        //public List<Producto> LeerBaseDeDatos()
        //{
        //    List<Producto> productos = new List<Producto>();
        //    try
        //    {
        //        sqlConnection.Open();
        //        Console.WriteLine("--- Conexion abierta ---");

        //        //sqlCommand.CommandText = "select p.Code, p.Description, s.Description as Subcategoria from Products p inner join UnitMeasures um on um.Id = p.UnitMeasureId inner join SubCategories s on s.Id = p.SubCategoryId order by p.LastModifiedOn desc";

        //        sqlCommand.CommandText = "select p.Code, p.Description, s.Description as Subcategoria from Products p inner join UnitMeasures um on um.Id = p.UnitMeasureId inner join SubCategories s on s.Id = p.SubCategoryId where p.IsOnColppy = 0 order by p.LastModifiedOn desc";

        //        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
        //        {
        //            while (dataReader.Read())
        //            {
        //                string codigo = dataReader["Code"].ToString();
        //                string descripcion = dataReader["Description"].ToString();
        //                string subCatergoria = dataReader["Subcategoria"].ToString();

        //                try
        //                {
        //                    Producto producto = new Producto(codigo, descripcion, subCatergoria);
        //                    productos.Add(producto);

        //                }
        //                catch (Exception ex)
        //                {
        //                    Console.WriteLine($"Error: {ex.Message}");
        //                }

        //            }
        //        }
        //        return productos;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //}

        public List<Producto> LeerBaseDeDatosPorFecha(string fechaInicio, string fechaFin)
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("spLeerProductosPorFecha", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);


                using (SqlDataReader dataReader = cmd.ExecuteReader())
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
                return null;
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

                SqlCommand cmd = new SqlCommand("spCambiarEstadoColppyProductos", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Code", Code);
                isOk = cmd.ExecuteNonQuery();

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
