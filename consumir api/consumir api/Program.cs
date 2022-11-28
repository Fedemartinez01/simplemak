using Entidades;
using Entidades.Clientes;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;


var url = "https://staging.colppy.com/lib/frontera2/service.php"; //URL de la api colppy

JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
ClienteSQL ClienteSQL = new ClienteSQL(); //Creamos conexion a base de datos

List<Cliente> clientes = new List<Cliente>();
clientes = ClienteSQL.LeerBaseDeDatos(); //Tramos de la base de datos a todos los clientes


var login = new Login //JSON LOGIN
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
string claveSesion;

RespuestaLogin respuestaLogin = new RespuestaLogin(); //Creamos el objeto respuestaLogin.. de acá sacamos el token

using (var httpClient = new HttpClient())
{

    var response = await httpClient.PostAsJsonAsync(url, login); //Mandamos por POST

    if (response.IsSuccessStatusCode)
    {
        try
        {
            var rta = await response.Content.ReadAsStringAsync();

            respuestaLogin = JsonSerializer.Deserialize<RespuestaLogin>(rta);

            claveSesion = respuestaLogin.response.data.claveSesion;

            Console.WriteLine(claveSesion);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Ha ocurrido un error: " + ex);
            claveSesion = "error";
        }
    }
    else
    {
        Console.WriteLine("Error");
    }

}



foreach (Cliente cliente in clientes)
{

    using (var httpClient = new HttpClient())
    {

        var response = await httpClient.PostAsJsonAsync(url, cliente); //Mandamos por POST

        if (response.IsSuccessStatusCode)
        {
            var rta = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Data: " + rta);
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
}


