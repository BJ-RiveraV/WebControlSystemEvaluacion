using HTTPClienteData.Interfaces;
using Shared;
using System.Net.Http.Json;
using System.Text.Json;

namespace HTTPClienteData.Clientes
{
    public class ClienteUsuarios : IClienteUsuarios
    {
        private readonly HttpClient _httpClient;

        public ClienteUsuarios(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ModeloRespuestaHTTP<string>> CrearUsuario(CreateUserDTO usuario)
        {
            try
            {
                var url = $"https://localhost:7116/api/usuarios";

                var respuestaHttp = await _httpClient.PostAsJsonAsync(url, usuario);

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    //var respuesta = JsonSerializer.Deserialize<string>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<string>(contenido, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<string>(default, true, respuestaHttp);
            }
            catch (Exception)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<string>(default, true, respuestaHttp);
            }
        }

        public async Task<ModeloRespuestaHTTP<string>> EditarUsuario(UpdateUserDTO usuario)
        {
            try
            {
                var url = $"https://localhost:7116/api/usuarios/editar";

                var respuestaHttp = await _httpClient.PostAsJsonAsync(url, usuario);

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    //var respuesta = JsonSerializer.Deserialize<string>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<string>(contenido, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<string>(default, true, respuestaHttp);
            }
            catch (Exception ex)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<string>(default, true, respuestaHttp);
            }
        }

        public async Task<ModeloRespuestaHTTP<string>> EliminarUsuario(int id)
        {
            try
            {
                var url = $"https://localhost:7116/api/usuarios/eliminar/{id}";

                var respuestaHttp = await _httpClient.PostAsJsonAsync(url, id);

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    //var respuesta = JsonSerializer.Deserialize<string>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<string>(contenido, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<string>(default, true, respuestaHttp);
            }
            catch (Exception ex)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<string>(default, true, respuestaHttp);
            }
        }

        public async Task<ModeloRespuestaHTTP<ObtenerUsuarioDTO>> ObtenerUsuario(int id)
        {
            try
            {
                var respuestaHttp = await _httpClient.GetAsync($"https://localhost:7116/api/usuarios/{id}");

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    var respuesta = JsonSerializer.Deserialize<ObtenerUsuarioDTO>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<ObtenerUsuarioDTO>(respuesta, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<ObtenerUsuarioDTO>(default, true, respuestaHttp);
            }
            catch (Exception ex)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<ObtenerUsuarioDTO>(default, true, respuestaHttp);
            }
        }

        public async Task<ModeloRespuestaHTTP<List<ObtenerUsuarioDTO>>> ObtenerUsuarios()
        {
            try
            {
                var respuestaHttp = await _httpClient.GetAsync("https://localhost:7116/api/usuarios");

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    var respuesta = JsonSerializer.Deserialize<List<ObtenerUsuarioDTO>>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<List<ObtenerUsuarioDTO>>(respuesta, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<List<ObtenerUsuarioDTO>>(default, true, respuestaHttp);
            }
            catch (Exception ex)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<List<ObtenerUsuarioDTO>>(default, true, respuestaHttp);
            }
        }
    }
}
