using Entidades.Clientes;
using Entidades.Productos;
using Entidades.Proveedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=SystemERP_DB;Integrated Security=True");

        public Conexion()
        {

        }

        #region Productos

        public List<Producto> LeerTodosProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("spLeerTodosProductosColppy", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

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
        public List<Producto> LeerProductos(string fechaInicio, string fechaFin)
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("spLeerProductosColppy", sqlConnection);
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
        public List<ProductoUpdate> LeerProductosUpdate(string fechaInicio, string fechaFin)
        {
            List<ProductoUpdate> productos = new List<ProductoUpdate>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("sp_LeerProductsUpdate", sqlConnection);
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
                        string idColppy = dataReader["IsOnColppy"].ToString();

                        try
                        {
                            ProductoUpdate productoUpdate = new ProductoUpdate(codigo, descripcion, subCatergoria, idColppy);
                            productos.Add(productoUpdate);

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
        public List<ProductoUpdate> LeerTodosProductosUpdate()
        {
            List<ProductoUpdate> productos = new List<ProductoUpdate>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("sp_LeerTodosProductsUpdate", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string codigo = dataReader["Code"].ToString();
                        string descripcion = dataReader["Description"].ToString();
                        string subCatergoria = dataReader["Subcategoria"].ToString();
                        string idColppy = dataReader["IsOnColppy"].ToString();

                        try
                        {
                            ProductoUpdate productoUpdate = new ProductoUpdate(codigo, descripcion, subCatergoria, idColppy);
                            productos.Add(productoUpdate);

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

        public void CambiarEstadoColppy(string Code, string idColppy)
        {
            var isOk = 0;
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("spSetIdOnColppyProductos", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idColppy", idColppy);
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

        #region Clientes

        public List<Cliente> LeerClientes(string fechaInicio, string fechaFin)
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("spLeerClientesPorFecha", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);


                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string isActive = "0";
                        string TipoDocumento = dataReader["DocumentType"].ToString();
                        string NumeroDocumento = dataReader["DocumentNumber"].ToString();
                        string Pais = dataReader["CountryName"].ToString();
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
                            dataReader["CityName"].ToString(),
                            Pais,
                            dataReader["CellPhoneNumber"].ToString(),
                            dataReader["Email"].ToString(),
                            //dataReader["CreatedOn"].ToString(),
                            //dataReader["CountryId"].ToString(),
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
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        #endregion

        #region Proveedores

        public List<Proveedor> LeerProveedores(string fechaInicio, string fechaFin)
        {
            List<Proveedor> proveedores = new List<Proveedor>();

            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("spLeerProveedoresPorFecha", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);


                using (SqlDataReader dataReader = cmd.ExecuteReader())
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
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        #endregion
    }
}
