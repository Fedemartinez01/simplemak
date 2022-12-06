using Entidades;
using Entidades.Clientes;
using Entidades.Productos;
using Entidades.Proveedores;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        #region Atributos

        string url = "https://staging.colppy.com/lib/frontera2/service.php"; //URL de la api colppy

        ClienteSQL ClienteSQL = new ClienteSQL(); //Creamos conexion a base de datos
        List<Cliente> clientes = new List<Cliente>();

        //ProductoSQL ProductoSQL = new ProductoSQL();
        List<Producto> productos = new List<Producto>();

        ProvedorSQL provedorSQL = new ProvedorSQL();
        List<Proveedor> proveedores= new List<Proveedor>();

        Login login = new Login
        {
            auth = new auth
            {
                usuario = "ntraficante@gmail.com",
                password = "e03c714818c4d45a033b467fa7b76797"
            },
            service = new service
            {
                provision = "Usuario",
                operacion = "iniciar_sesion"
            },
            parameters = new parameters
            {
                usuario = "administracion@simplemak.com.ar",
                password = "87222e72461dfe5a910ad200e54f3ace"
            }
        }; //Creamos el objeto login

        string claveSesion = "null";

        RespuestaLogin respuestaLogin = new RespuestaLogin(); //Creamos el objeto respuestaLogin.. de acá sacamos el token

        #endregion

        #region Constructor
        public frmPrincipal()
        {
            InitializeComponent();

            clientes = ClienteSQL.LeerBaseDeDatos(); // Tramos listado de base de datos
            proveedores = provedorSQL.LeerBaseDeDatos();
            CargarClientes(clientes); // Cargamos en pantalla los clientes
            CargarProveedores(proveedores);
            this.cmbVistaListado.Text = "Clientes";
            ObtenerToken(); // Obtenemos un nuevo token
        }
        #endregion

        #region Métodos

        #region Botones
        private void btnObtenerToken_Click(object sender, EventArgs e)
        {
            ObtenerToken();
        }
        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            AgregarClientes();
        }
        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            AgregarProveedores();
        }
        #endregion

        #region AgregarEnAPI

        private async void AgregarProductos()
        {
            try
            {
                if (claveSesion == "null") //Validamos que se haya generado el token
                    throw new Exception();

                foreach (Producto producto in productos)
                {
                    producto.parameters.sesion.claveSesion = claveSesion; // Asignamos el token generado al parámetro correspondiente

                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsJsonAsync(url, producto); // Realizamos la llamada a la API

                        if (response.IsSuccessStatusCode)
                        {
                            var rta = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(rta);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de datos: {ex.Message}", "Exception controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void AgregarProveedores()
        {
            try
            {
                if (claveSesion == "null") //Validamos que se haya generado el token
                    throw new Exception();

                foreach (Proveedor proveedor in proveedores)
                {
                    proveedor.parameters.sesion.claveSesion = claveSesion; // Asignamos el token generado al parámetro correspondiente

                    string aux = JsonConvert.SerializeObject(proveedor);

                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsJsonAsync(url, proveedor); // Realizamos la llamada a la API

                        if (response.IsSuccessStatusCode)
                        {
                            var rta = await response.Content.ReadAsStringAsync();
                            //provedorSQL.CambiarEstadoColppy(proveedor.parameters.NombreFantasia); //Cambia el estado de colppy a 1 en la base de datos
                            MessageBox.Show(rta);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de datos: {ex.Message}", "Exception controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void AgregarClientes()
        {
            try
            {
                if (claveSesion == "null") //Validamos que se haya generado el token
                    throw new Exception();

                foreach (Cliente cliente in clientes)
                {                    
                    cliente.parameters.sesion.claveSesion = claveSesion; // Asignamos el token generado al parámetro correspondiente

                    string aux = JsonConvert.SerializeObject(cliente);//JSON enviado a la API

                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsJsonAsync(url, cliente); // Realizamos la llamada a la API

                        if (response.IsSuccessStatusCode)
                        {
                            var rta = await response.Content.ReadAsStringAsync();
                            //ClienteSQL.CambiarEstadoColppy(cliente.parameters.info_general.NombreFantasia);
                            
                            MessageBox.Show(rta + "\n\n" + aux);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de datos: {ex.Message}", "Exception controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void CargarClientes(List<Cliente> lista)
        {

            foreach (Cliente cliente in lista)
            {
                int i = this.listadoClientes.Rows.Add();

                this.listadoClientes.Rows[i].Cells[0].Value = cliente.parameters.info_general.NombreFantasia;
                this.listadoClientes.Rows[i].Cells[1].Value = cliente.parameters.info_general.RazonSocial;
                this.listadoClientes.Rows[i].Cells[2].Value = cliente.parameters.info_general.CUIT;
                this.listadoClientes.Rows[i].Cells[3].Value = cliente.parameters.info_general.dni;
                this.listadoClientes.Rows[i].Cells[4].Value = cliente.parameters.info_general.DirPostal;
                this.listadoClientes.Rows[i].Cells[5].Value = cliente.parameters.info_general.DirPostalCiudad;
                this.listadoClientes.Rows[i].Cells[6].Value = cliente.parameters.info_general.DirPostalCodigoPostal;
                this.listadoClientes.Rows[i].Cells[7].Value = cliente.parameters.info_general.DirPostalProvincia;
                this.listadoClientes.Rows[i].Cells[8].Value = cliente.parameters.info_general.DirPostalPais;
                this.listadoClientes.Rows[i].Cells[9].Value = cliente.parameters.info_general.Telefono;
                this.listadoClientes.Rows[i].Cells[10].Value = cliente.parameters.info_general.Email;
                this.listadoClientes.Rows[i].Cells[11].Value = cliente.parameters.info_otra.Activo;
                this.listadoClientes.Rows[i].Cells[12].Value = cliente.parameters.info_otra.FechaAlta;
            }
        }
        private void CargarProveedores(List<Proveedor> lista)
        {

            foreach (Proveedor proveedor in lista)
            {
                int i = this.listadoProveedores.Rows.Add();

                this.listadoProveedores.Rows[i].Cells[0].Value = proveedor.parameters.NombreFantasia;
                this.listadoProveedores.Rows[i].Cells[1].Value = proveedor.parameters.RazonSocial;
                this.listadoProveedores.Rows[i].Cells[2].Value = proveedor.parameters.DirPostal;
                this.listadoProveedores.Rows[i].Cells[3].Value = proveedor.parameters.DirPostalCiudad;
                this.listadoProveedores.Rows[i].Cells[4].Value = proveedor.parameters.DirPostalCodigoPostal;
                this.listadoProveedores.Rows[i].Cells[5].Value = proveedor.parameters.DirPostalProvincia;
                this.listadoProveedores.Rows[i].Cells[6].Value = proveedor.parameters.DirPostalPais;
                this.listadoProveedores.Rows[i].Cells[7].Value = proveedor.parameters.CUIT;
                this.listadoProveedores.Rows[i].Cells[8].Value = proveedor.parameters.idUsuario;
                this.listadoProveedores.Rows[i].Cells[9].Value = proveedor.parameters.Activo;
                this.listadoProveedores.Rows[i].Cells[10].Value = proveedor.parameters.idCondicionIva;

            }
        }
        private async void ObtenerToken()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsJsonAsync(url, login); //Mandamos por POST

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var rta = await response.Content.ReadAsStringAsync();

                        respuestaLogin = JsonSerializer.Deserialize<RespuestaLogin>(rta); // Deserializamos la respuesta del login para poder obtener el atributo claveSesion

                        if (respuestaLogin != null)
                            claveSesion = respuestaLogin.response.data.claveSesion;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ha ocurrido un error: " + ex);
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        private void CambioListado(object sender, EventArgs e)
        {
            switch (this.cmbVistaListado.Text)
            {
                case "Proveedores":
                    listadoClientes.Hide();
                    listadoProveedores.Show();
                    break;

                case "Productos":
                    listadoClientes.Hide();
                    listadoProveedores.Hide();
                    break;

                case "Clientes":
                    listadoClientes.Show();
                    listadoProveedores.Hide();
                    break;

                default:
                    listadoClientes.Hide();
                    listadoProveedores.Hide();
                    break;
            }
        }

        private void btnCargarTodos_Click(object sender, EventArgs e)
        {
            AgregarClientes();
            AgregarProductos();
            AgregarProveedores();
        }
    }

    #endregion
}