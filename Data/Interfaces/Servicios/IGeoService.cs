using Shared;

namespace Data.Interfaces.Servicios
{
    public interface IGeoService
    {
        public List<ObtenerDepartamentoDTO> ObtenerDepartamentos(); 
        public List<ObtenerProvinciaDTO> ObtenerProvinciasPorDepartamento(int id); 
    }
}
