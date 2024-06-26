using Shared;

namespace FrontASP.Models.ModelosFormularios
{
    internal class EditarUsuario
    {
        public UpdateUserDTO usuario { get; set; } = new UpdateUserDTO();
        public List<ObtenerDepartamentoDTO> departamentos { get; set; } = new List<ObtenerDepartamentoDTO>();
        public List<ObtenerProvinciaDTO> provincias { get; set; } = new List<ObtenerProvinciaDTO>();
    }
}
