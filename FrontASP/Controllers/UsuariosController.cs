using HTTPClienteData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace FrontASP.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IClienteUsuarios _clienteUsuarios;
        private readonly IClienteGeo _clienteGeo;

        public UsuariosController(IClienteUsuarios clienteUsuarios, IClienteGeo clienteGeo)
        {
            _clienteUsuarios = clienteUsuarios;
            _clienteGeo = clienteGeo;
        }

        public async Task<IActionResult> Index()
        {
            var respuesta = await _clienteUsuarios.ObtenerUsuarios();

            if (respuesta.Error)
            {
                return View();
            }

            return View(respuesta.Response);
        }

        public IActionResult Crear()
        {
            
            return View(new CreateUserDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Crear(CreateUserDTO usuario)
        {
            if (ModelState.IsValid)
            {
                var respuesta = await _clienteUsuarios.CrearUsuario(usuario);
                if (!respuesta.Error)
                {
                    TempData["success"] = "El usuario fue creado";
                    return RedirectToAction("Index");
                }
            }
            return View(usuario);
        }

        public async Task<IActionResult> Editar(int id)
        {
            var respuesta = await _clienteUsuarios.ObtenerUsuario(id);

            if (respuesta.Error)
            {
                return RedirectToAction("Index");
            }

            var usuario = respuesta.Response;
            var usuarioEditar = new UpdateUserDTO()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Correo = usuario.Correo,
                Direccion = usuario.Direccion,
                FechaNacimiento = usuario.FechaNacimiento,
                NumeroDocumento = usuario.NumeroDocumento,
                ProvinciaId = usuario.ProvinciaId,
                Sexo = usuario.Sexo
            };

            var respuestaDepaartamentos = await _clienteGeo.ObtenerDepartamentos();
            var departamentos = respuestaDepaartamentos.Response;

            foreach (var departamento in departamentos)
            {

                if (departamento.Provincias.Any(p => p.Id == usuarioEditar.ProvinciaId))
                {
                    usuarioEditar.DepartamentoId = departamento.Id;
                }
            }

            return View(usuarioEditar);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(UpdateUserDTO usuario)
        {

            if (ModelState.IsValid)
            {
                var respuesta = await _clienteUsuarios.EditarUsuario(usuario);
                if (!respuesta.Error)
                {
                    TempData["success"] = "El usuario fue actualizado";
                    return RedirectToAction("Index");
                }
            }
            return View(usuario);
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
            var respuesta = await _clienteUsuarios.EliminarUsuario(id);
            if (respuesta.Error)
            {
                var mensaje = await respuesta.ObtenerMensajeError();
                TempData["error"] = mensaje;
                return Json(new { success = false, message = mensaje });

            }
            TempData["success"] = "El usuario fue eliminado";
            return Json(new { success = true, message = "Deleted Successful" });
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerProvinciasPorDepartamento(int id)
        {
            var respuesta = await _clienteGeo.ObtenerProvinciasPorDepartamento(id);
            var provincias = respuesta.Response;
            return Json(provincias);
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerDepartamentos()
        {
            var respuesta = await _clienteGeo.ObtenerDepartamentos();
            var departamentos = respuesta.Response;
            return Json(departamentos);
        }

    }
}
