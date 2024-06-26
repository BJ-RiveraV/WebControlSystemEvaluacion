using Shared;

namespace FrontASP.Models.ModelosFormularios
{
    internal class CrearUsuario
    {
        public CreateUserDTO usuario { get; set; } = new CreateUserDTO();
        public List<ObtenerDepartamentoDTO> departamentos { get; set; } = new List<ObtenerDepartamentoDTO>();
        public List<ObtenerProvinciaDTO> provincias { get; set; } = new List<ObtenerProvinciaDTO>();
    }
}
