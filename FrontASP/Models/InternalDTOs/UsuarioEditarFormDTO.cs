using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shared;

namespace FrontASP.Models.InternalDTOs
{
    public class UsuarioEditarFormDTO
    {
        public UpdateUserDTO usuario { get; set; } = new UpdateUserDTO();

        [ValidateNever]
        public IEnumerable<SelectListItem> departamentos { get; set; } = new List<SelectListItem>();

        [ValidateNever]
        public List<ObtenerProvinciaDTO> provincias { get; set; } = new List<ObtenerProvinciaDTO>();

        [ValidateNever]
        public int departamentoId { get; set; } = 0;
    }
}
