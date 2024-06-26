using Data.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Globalization;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _userService;

        public UsuarioController(IUsuarioService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<ObtenerUsuarioDTO>> ObtenerTodos()
        {
            return Ok(_userService.ObtenerTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<ObtenerUsuarioDTO> ObtenerPorId(int id)
        {
            var usuario = _userService.ObtenerPorId(id);

            if (usuario is null)
            {
                return BadRequest("El usuario no existe en la base de datos");
            }

            return Ok(usuario);
        }

        [HttpPost("eliminar/{id}")]
        public ActionResult<string> Eliminar(int id)
        {
            var respuesta = _userService.Eliminar(id);

            return !respuesta.HayError ? Ok("El usuario fue eliminado de la base de datos") : BadRequest(respuesta); 
        }

        [HttpPost("editar")]
        public ActionResult<string> Editar(UpdateUserDTO usuario)
        {
            string errores = "";

            var fecha = usuario.FechaNacimiento.Date;
            if (fecha >= DateTime.Now.Date)
            {
                ModelState.AddModelError("Fecha de Nacimiento", "La Fecha de nacimiento debe ser menor a la fecha actual");
            }

            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        errores += error.ErrorMessage;
                    }
                }
                return BadRequest(errores);
            }

            var respuesta = _userService.Editar(usuario);

            if (respuesta.HayError)
            {
                return BadRequest(respuesta.Error);
            }

            return Ok("Usuario actualizado exitosamente");

        }

        [HttpPost]
        public ActionResult<string> Crear(CreateUserDTO usuario)
        {
            string errores = "";


            if (usuario.FechaNacimiento >= DateTime.Now.Date)
            {
                ModelState.AddModelError("Fecha de Nacimiento", "La Fecha de nacimiento debe ser menor a la fecha actual");
            }

            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        errores += error.ErrorMessage;
                    }
                }
                return BadRequest(errores);
            }

            var respuesta = _userService.Agregar(usuario);

            if (respuesta.HayError)
            {
                return BadRequest(respuesta.Error);
            }

            return Ok("Usuario creado exitosamente");

        }
    }
}
