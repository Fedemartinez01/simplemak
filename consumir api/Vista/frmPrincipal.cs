using Entidades;
using Entidades.Clientes;
using Entidades.Productos;
using Entidades.Proveedores;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.SS.Formula.Functions;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Entidades.Excepciones;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Reflection.Metadata;
using System.Threading;
using System;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        #region Atributos

        string url = "https://staging.colppy.com/lib/frontera2/service.php"; //URL de la api colppy

        //string urlProduccion = "https://login.colppy.com/lib/frontera2/service.php";

        Conexion Conexion = new Conexion();

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
        };

        string claveSesion = "null";

        RespuestaLogin respuestaLogin = new RespuestaLogin(); //Creamos el objeto respuestaLogin.. de acá sacamos el token

        bool primerCarga = true;


        #endregion

        #region Constructor
        public frmPrincipal()
        {
            //ObtenerToken(); // Obtenemos un nuevo token

            Task obtenerToken = Task.Factory.StartNew(() => ObtenerToken());
            Task.WaitAll(obtenerToken);
            Task.Delay(2000).Wait();

            InitializeComponent();

            this.radio_2.Checked = true;
            this.lbl_Fechas.SelectedIndex = 0;
            //this.btnCargarClientes.Enabled = false;
            this.btnCargarTodos.Enabled = false;
            this.btnCargarProveedores.Enabled = false;


            Sincronizar();
            primerCarga = false;
        }
        #endregion

        #region Botones
        private void btnObtenerToken_Click(object sender, EventArgs e)
        {
            ObtenerToken();
        }
        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            BloquearInputs();

            #region Asignar fecha
            DateTime fechaInicio = DateTime.Today;
            DateTime fechaFin = DateTime.Now;

            if (group2.Enabled)
            {
                switch (this.lbl_Fechas.Text)
                {
                    case "Hoy":
                        fechaInicio = DateTime.Today;
                        break;
                    case "Últimos 3 días":
                        fechaInicio = DateTime.Today.AddDays(-3);
                        break;
                    case "Últimos 10 días":
                        fechaInicio = DateTime.Today.AddDays(-10);
                        break;
                }
            }
            else if (group1.Enabled)
            {
                fechaInicio = this.txt_FechaInicio.Value;
                fechaFin = this.txt_FechaFin.Value;
            }
            #endregion

            AgregarClientes(fechaInicio, fechaFin);
        }
        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            BloquearInputs();

            #region Asignar fecha
            DateTime fechaInicio = DateTime.Today;
            DateTime fechaFin = DateTime.Now;

            if (group2.Enabled)
            {
                switch (this.lbl_Fechas.Text)
                {
                    case "Hoy":
                        fechaInicio = DateTime.Today;
                        break;
                    case "Últimos 3 días":
                        fechaInicio = DateTime.Today.AddDays(-3);
                        break;
                    case "Últimos 10 días":
                        fechaInicio = DateTime.Today.AddDays(-10);
                        break;
                }
            }
            else if (group1.Enabled)
            {
                fechaInicio = this.txt_FechaInicio.Value;
                fechaFin = this.txt_FechaFin.Value;
            }
            #endregion

            AgregarProveedores(fechaInicio, fechaFin);
        }
        private void btnCargarProductos_Click_1(object sender, EventArgs e)
        {
            BloquearInputs();

            #region Asignar fecha
            DateTime fechaInicio = DateTime.Today;
            DateTime fechaFin = DateTime.Now;

            if (group2.Enabled)
            {
                switch (this.lbl_Fechas.Text)
                {
                    case "Hoy":
                        fechaInicio = DateTime.Today;
                        break;
                    case "Últimos 3 días":
                        fechaInicio = DateTime.Today.AddDays(-3);
                        break;
                    case "Últimos 10 días":
                        fechaInicio = DateTime.Today.AddDays(-10);
                        break;
                }
            }
            else if (group1.Enabled)
            {
                fechaInicio = this.txt_FechaInicio.Value;
                fechaFin = this.txt_FechaFin.Value;
            }
            #endregion

            AgregarProductos(fechaInicio, fechaFin);
        }
        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            BloquearInputs();

            #region Asignar fecha
            DateTime fechaInicio = DateTime.Today;
            DateTime fechaFin = DateTime.Now;

            if (group2.Enabled)
            {
                switch (this.lbl_Fechas.Text)
                {
                    case "Hoy":
                        fechaInicio = DateTime.Today;
                        break;
                    case "Últimos 3 días":
                        fechaInicio = DateTime.Today.AddDays(-3);
                        break;
                    case "Últimos 10 días":
                        fechaInicio = DateTime.Today.AddDays(-10);
                        break;
                }
            }
            else if(group1.Enabled)
            {
                fechaInicio = this.txt_FechaInicio.Value;
                fechaFin = this.txt_FechaFin.Value;
            }
            #endregion

            EditarProductos(fechaInicio, fechaFin);
        }
        #endregion

        #region AgregarEnAPI

        private async void AgregarProductos(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                if (claveSesion == "null")
                    throw new ExceptionColppy();

                List<Producto> productos = new List<Producto>();

                frmLeyendoBaseDeDatos frmLeyendoBBDD = new frmLeyendoBaseDeDatos();
                frmLeyendoBBDD.Show();

                if (primerCarga)
                {
                    productos = Conexion.LeerTodosProductos();
                    //ObtenerToken();
                }
                else
                {
                    if(this.checkTodos.Checked)
                    {
                        productos = Conexion.LeerTodosProductos();
                    }
                    else
                    {
                        #region Formatear fecha
                    string fechaInicioSQL = $"{fechaInicio.Year}-{fechaInicio.Month}-{fechaInicio.Day}";

                    string fechaFinSql = $"{fechaFin.Year}-{fechaFin.Month}-{fechaFin.Day} 23:59:59";

                        #endregion

                        productos = Conexion.LeerProductos(fechaInicioSQL, fechaFinSql);
                    }

                    if (productos is null)
                        throw new ExceptionEntidadNull();
                    
                }

                frm_Cargando frm_Cargando = new frm_Cargando(productos.Count, this);
                frmLeyendoBBDD.Close();
                frm_Cargando.Show();
                frm_Cargando.Cancel = true;

                var cantProductosAgregados = 0;
                var cantProductosNoAgregados = 0;

                #region Carga

                if (productos.Count > 0)
                {
                    string idProductoColppy;

                    foreach (var producto in productos)
                    {
                        if (frm_Cargando.Cancel is true)
                        {
                            producto.parameters.sesion.claveSesion = claveSesion;
                            using (var httpClient = new HttpClient())
                            {
                                var response = await httpClient.PostAsJsonAsync(url, producto);

                                if (response.IsSuccessStatusCode)
                                {
                                    var rtaString = await response.Content.ReadAsStringAsync();

                                    if (rtaString.Contains("\"message\": \"La operación se realizó con éxito.\"") || rtaString.Contains("\"message\":\"La operaci\\u00f3n se realiz\\u00f3 con \\u00e9xito.\""))
                                    {
                                        RespuestaAltaProducto rta = JsonConvert.DeserializeObject<RespuestaAltaProducto>(rtaString);

                                        idProductoColppy = rta.response.data.idItem.ToString();

                                        cantProductosAgregados++;

                                        Conexion.CambiarEstadoColppy(producto.parameters.codigo, idProductoColppy);
                                    }
                                    else //SOLO PARA CONTROLAR 
                                    {
                                        cantProductosNoAgregados++;
                                    }
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                #endregion
               
                frm_Cargando.Close();

                MessageBox.Show($"CARGA DE PRODUCTOS FINALZADA\nPRODUCTOS NUEVOS AGREGADOS: {cantProductosAgregados}\nNO AGREGADOS: {cantProductosNoAgregados}");

                DesbloquearInputs();

            }
            catch (ExceptionColppy)
            {
                MessageBox.Show($"Colppy no se encuentra disponible", "No se ha podido realizar la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Hubo un error en carga de datos", "No se ha podido realizar la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private async void AgregarProveedores(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                #region Convertir a formato fecha SQL
                string fechaInicioSQL = $"{fechaInicio.Year}-{fechaInicio.Month}-{fechaInicio.Day}";

                string fechaFinSql = $"{fechaFin.Year}-{fechaFin.Month}-{fechaFin.Day} 23:59:59";

                #endregion

                frmLeyendoBaseDeDatos frmLeyendoBBDD = new frmLeyendoBaseDeDatos();
                frmLeyendoBBDD.Show();

                List<Proveedor> proveedores = new List<Proveedor>();
                proveedores = Conexion.LeerProveedores(fechaInicioSQL, fechaFinSql);

                if (claveSesion == "null") //Validamos que se haya generado el token
                    throw new Exception();

                frm_Cargando frm_Cargando = new frm_Cargando(proveedores.Count);
                frmLeyendoBBDD.Close();
                frm_Cargando.Show();

                var cantProveedoresAgregados = 0;

                if(proveedores is not null)
                { 
                    foreach (Proveedor proveedor in proveedores)
                    {
                        proveedor.parameters.sesion.claveSesion = claveSesion; // Asignamos el token generado al parámetro correspondiente

                        string aux = JsonConvert.SerializeObject(proveedor);

                        using (var httpClient = new HttpClient())
                        {
                            var response = await httpClient.PostAsJsonAsync(url, proveedor); // Realizamos la llamada a la API

                            if (response.IsSuccessStatusCode)
                            {
                                var rtaString = await response.Content.ReadAsStringAsync();

                                if (rtaString.Contains("\"message\": \"La operación se realizó con éxito.\"") || rtaString.Contains("\"message\":\"La operaci\\u00f3n se realiz\\u00f3 con \\u00e9xito.\""))
                                {
                                    cantProveedoresAgregados++;
                                    //cambiar estado de colppy
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }             
                        MessageBox.Show("CARGA DE PROVEEDORES FINALZADA\nPROVEEDORES NUEVOS AGREGADOS: " + cantProveedoresAgregados);
                }
                frm_Cargando.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de datos: {ex.Message}", "Exception controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void AgregarClientes(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                if (claveSesion == "null") //Validamos que se haya generado el token
                    throw new Exception();

                #region Convertir a formato fecha SQL
                string fechaInicioSQL = $"{fechaInicio.Year}-{fechaInicio.Month}-{fechaInicio.Day}";

                string fechaFinSql = $"{fechaFin.Year}-{fechaFin.Month}-{fechaFin.Day} 23:59:59";

                #endregion

                frmLeyendoBaseDeDatos frmLeyendoBBDD = new frmLeyendoBaseDeDatos();
                frmLeyendoBBDD.Show();

                List<Cliente> clientes = new List<Cliente>();
                clientes = Conexion.LeerClientes(fechaInicioSQL, fechaFinSql);

                frm_Cargando frm_Cargando = new frm_Cargando(clientes.Count);
                frmLeyendoBBDD.Close();
                frm_Cargando.Show();

                var cantClientesAgregados = 0;

                if(clientes is not null)
                { 
                    foreach (Cliente cliente in clientes)
                    {
                        cliente.parameters.sesion.claveSesion = claveSesion; // Asignamos el token generado al parámetro correspondiente

                        string aux = JsonConvert.SerializeObject(cliente);//JSON enviado a la API

                        using (var httpClient = new HttpClient())
                        {
                            var response = await httpClient.PostAsJsonAsync(url, cliente); // Realizamos la llamada a la API

                            if (response.IsSuccessStatusCode)
                            {
                                var rtaString = await response.Content.ReadAsStringAsync();

                                if (rtaString.Contains("\"message\": \"La operación se realizó con éxito.\"") || rtaString.Contains("\"message\":\"La operaci\\u00f3n se realiz\\u00f3 con \\u00e9xito.\""))
                                {
                                    cantClientesAgregados++;
                                    //cambiar estado de colppy
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                        MessageBox.Show("CARGA DE CLIENTES FINALZADA\nCLIENTES NUEVOS AGREGADOS: " + cantClientesAgregados);
                }
                frm_Cargando.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de datos: {ex.Message}", "Exception controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void EditarProductos(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                frmLeyendoBaseDeDatos frmLeyendoBBDD = new frmLeyendoBaseDeDatos();
                frmLeyendoBBDD.Show();

                List<ProductoUpdate> productosUpdate = new List<ProductoUpdate>();

                if(!this.checkTodos.Checked)
                {
                    #region Formatear fecha
                string fechaInicioSQL = $"{fechaInicio.Year}-{fechaInicio.Month}-{fechaInicio.Day}";

                string fechaFinSql = $"{fechaFin.Year}-{fechaFin.Month}-{fechaFin.Day} 23:59:59";

                #endregion

                    productosUpdate = Conexion.LeerProductosUpdate(fechaInicioSQL, fechaFinSql);
                }
                else
                {
                    productosUpdate = Conexion.LeerTodosProductosUpdate();
                }

                #region Validamos excepciones

                if (claveSesion == "null") //Validamos que se haya generado el token
                    throw new ExceptionColppy();

                if (productosUpdate is null)
                    throw new ExceptionEntidadNull();
                #endregion

                frm_Cargando frm_Cargando = new frm_Cargando(productosUpdate.Count);
                frmLeyendoBBDD.Close();
                frm_Cargando.Show();

                var cantProductosActualizados = 0;
                var cantProductosNoActualizados = 0;

                #region Update
                if (productosUpdate.Count > 0)
                {
                    foreach (var producto in productosUpdate)
                    {
                        if (frm_Cargando.Cancel is true)
                        {
                            producto.parameters.sesion.claveSesion = claveSesion;
                            using (var httpClient = new HttpClient())
                            {
                                var response = await httpClient.PostAsJsonAsync(url, producto);

                                if (response.IsSuccessStatusCode)
                                {
                                    var rtaString = await response.Content.ReadAsStringAsync();

                                    if (rtaString.Contains("\"message\": \"La operación se realizó con éxito.\"") || rtaString.Contains("\"message\":\"La operaci\\u00f3n se realiz\\u00f3 con \\u00e9xito.\""))
                                    {
                                        cantProductosActualizados++;
                                    }
                                    else
                                    {
                                        cantProductosNoActualizados++;
                                    }
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                        }
                    }
                }
                #endregion

                MessageBox.Show($"ACTUALIZACION DE PRODUCTOS FINALZADA\nPRODUCTOS ACTUALIZADOS: {cantProductosActualizados}\nNO ACTUALIZADOS: {cantProductosNoActualizados}");

                frm_Cargando.Close();
                DesbloquearInputs();
            }
            catch (ExceptionColppy)
            {
                MessageBox.Show($"Colppy no se encuentra disponible", "No se ha podido realizar la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ExceptionEntidadNull)
            {
                MessageBox.Show($"No se ha podido traer la informacion", "No se ha podido realizar la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Hubo un error en carga de datos", "No se ha podido realizar la carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void Sincronizar()
        {
            AgregarProductos(DateTime.Now, DateTime.Now);
            //AgregarProveedores(DateTime.Now, DateTime.Now);
            //AgregarClientes(DateTime.Now, DateTime.Now);        
        }

        #endregion

        #region Bloquear labels

        public void BloquearInputs()
        {
            this.btnCargarClientes.Enabled = false;
            this.btnCargarProductos.Enabled = false;
            this.btnCargarProveedores.Enabled = false;
            this.btnEditarProductos.Enabled = false;
            this.btnCargarTodos.Enabled = false;

            this.txt_FechaFin.Enabled = false;
            this.txt_FechaInicio.Enabled = false;
        }
        public void DesbloquearInputs()
        {
            //this.btnCargarClientes.Enabled = true;
            this.btnCargarProductos.Enabled = true;
            this.btnEditarProductos.Enabled = true;
            //this.btnCargarProveedores.Enabled = true;
            //this.btnCargarTodos.Enabled = true;
            this.txt_FechaFin.Enabled = true;
            this.txt_FechaInicio.Enabled = true;
        }
        private void radio_1_CheckedChanged(object sender, EventArgs e)
        {
            group1.Enabled = true;
            group2.Enabled = false;
        }
        private void radio_2_CheckedChanged(object sender, EventArgs e)
        {
            group1.Enabled = false;
            group2.Enabled = true;
        }
        private void radio_3_CheckedChanged(object sender, EventArgs e)
        {
            group1.Enabled = false;
            group2.Enabled = false;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            BloquearInputs();
        }

        #endregion

    }
    
}