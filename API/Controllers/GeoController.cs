using Data.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/geo")]
    public class GeoController : ControllerBase
    {
        private readonly IGeoService _geoService;

        public GeoController(IGeoService geoService)
        {
            _geoService = geoService;
        }

        [HttpGet]
        public ActionResult<List<ObtenerDepartamentoDTO>> ObtenerDepartamentos() 
        {
            return _geoService.ObtenerDepartamentos();
        }

        [HttpGet("{id}")]
        public ActionResult<List<ObtenerProvinciaDTO>> ObtenerProvinciasPorDepartamento(int id)
        {
            return _geoService.ObtenerProvinciasPorDepartamento(id);
        }
    }
}
