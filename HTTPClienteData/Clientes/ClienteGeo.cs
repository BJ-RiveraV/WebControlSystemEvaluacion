using HTTPClienteData.Interfaces;
using Shared;
using System.Text.Json;

namespace HTTPClienteData.Clientes
{
    public class ClienteGeo : IClienteGeo
    {
        private readonly HttpClient _httpClient;

        public ClienteGeo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ModeloRespuestaHTTP<List<ObtenerDepartamentoDTO>>> ObtenerDepartamentos()
        {
            try
            {
                var respuestaHttp = await _httpClient.GetAsync("https://localhost:7116/api/geo");

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    var respuesta = JsonSerializer.Deserialize<List<ObtenerDepartamentoDTO>>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<List<ObtenerDepartamentoDTO>>(respuesta, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<List<ObtenerDepartamentoDTO>>(default, true, respuestaHttp);
            }
            catch (Exception ex)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<List<ObtenerDepartamentoDTO>>(default, true, respuestaHttp);
            }
        }

        public async Task<ModeloRespuestaHTTP<List<ObtenerProvinciaDTO>>> ObtenerProvinciasPorDepartamento(int id)
        {
            try
            {
                var respuestaHttp = await _httpClient.GetAsync($"https://localhost:7116/api/geo/{id}");

                if (respuestaHttp.IsSuccessStatusCode)
                {
                    var contenido = await respuestaHttp.Content.ReadAsStringAsync();
                    var respuesta = JsonSerializer.Deserialize<List<ObtenerProvinciaDTO>>(contenido, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    return new ModeloRespuestaHTTP<List<ObtenerProvinciaDTO>>(respuesta, false, respuestaHttp);
                }

                return new ModeloRespuestaHTTP<List<ObtenerProvinciaDTO>>(default, true, respuestaHttp);
            }
            catch (Exception ex)
            {
                var respuestaHttp = new HttpResponseMessage();
                respuestaHttp.StatusCode = System.Net.HttpStatusCode.Conflict;
                return new ModeloRespuestaHTTP<List<ObtenerProvinciaDTO>>(default, true, respuestaHttp);
            }
        }
    }
}
