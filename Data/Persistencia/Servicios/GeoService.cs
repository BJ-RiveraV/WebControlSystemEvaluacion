using Data.Interfaces.Repositorios;
using Data.Interfaces.Servicios;
using Shared;

namespace Data.Persistencia.Servicios
{
    public class GeoService : IGeoService
    {
        private readonly IGeoRepository _geoRepository;

        public GeoService(IGeoRepository geoRepository)
        {
            this._geoRepository = geoRepository;
        }

        public List<ObtenerDepartamentoDTO> ObtenerDepartamentos()
        {
            var departamentos = _geoRepository.ObtenerDepartamentos();
            var departamentosDto = new List<ObtenerDepartamentoDTO>();           

            foreach (var departamento in departamentos)
            {
                var provinciasDto = new List<ObtenerProvinciaDTO>();
                foreach (var provincia in departamento.Provincias)
                {
                    provinciasDto.Add(new ObtenerProvinciaDTO() 
                    { Id = provincia.Id, Nombre = provincia.Nombre, DepartamentoId = provincia.DepartamentoId });
                }

                departamentosDto.Add(
                    new ObtenerDepartamentoDTO() { Id= departamento.Id, Nombre= departamento.Nombre, Provincias = provinciasDto });
            }

            return departamentosDto;
        }

        public List<ObtenerProvinciaDTO> ObtenerProvinciasPorDepartamento(int id)
        {
            var provincias = _geoRepository.ObtenerProvinciasPorDepartamento(id);
            var provinciasDto = new List<ObtenerProvinciaDTO>();

            foreach (var provincia in provincias)
            {
                provinciasDto.Add(new ObtenerProvinciaDTO()
                {
                    Id = provincia.Id,
                    Nombre = provincia.Nombre,
                    DepartamentoId = provincia.DepartamentoId
                });
            }

            return provinciasDto;
        }
    }
}
