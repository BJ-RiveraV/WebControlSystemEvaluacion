using Shared;

namespace HTTPClienteData.Interfaces
{
    public interface IClienteGeo
    {
        Task<ModeloRespuestaHTTP<List<ObtenerDepartamentoDTO>>> ObtenerDepartamentos();
        Task<ModeloRespuestaHTTP<List<ObtenerProvinciaDTO>>> ObtenerProvinciasPorDepartamento(int id);
    }
}
