using Data.Interfaces.Repositorios;
using Data.Interfaces.Servicios;
using Data.Modelos;
using Microsoft.Data.SqlClient;
using Shared;

namespace Data.Persistencia.Servicios
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public ModeloRespuesta Agregar(CreateUserDTO usuario)
        {
            var nuevoUsuario = new Usuario()
            {
                Nombre = usuario.Nombre,
                FechaNacimiento = usuario.FechaNacimiento,
                NumeroDocumento = usuario.NumeroDocumento,
                Direccion = usuario.Direccion,
                Correo = usuario.Correo,
                ProvinciaId = usuario.ProvinciaId,
                Sexo = usuario.Sexo,
            };

            try
            {
                _usuarioRepository.Insertar(nuevoUsuario);
                return new ModeloRespuesta()
                {
                    HayError = false
                };
            }
            catch (Exception ex) when (ex.InnerException is SqlException)
            {
                var codigo = (SqlException)ex.InnerException;
                if (codigo.Number == 2601)
                {
                    return new ModeloRespuesta()
                    {
                        HayError = true,
                        Error = "El DNI o Correo ya fueron registrados, no puede ingresar datos duplicados"
                    };
                }

                return new ModeloRespuesta()
                {
                    HayError = true,
                    Error = ex.Message.ToString()
                };
            }
            catch (Exception e)
            {
                return new ModeloRespuesta()
                {
                    HayError = true,
                    Error = e.Message.ToString()
                };
            }
        }

        public ModeloRespuesta Editar(UpdateUserDTO usuario)
        {
            var usuarioAEditar = _usuarioRepository.ObtenerPorId(usuario.Id);

            if (usuarioAEditar is null)
            {
                return new ModeloRespuesta()
                {
                    HayError = true,
                    Error = "El Usuario no existe en la base de datos"
                };
            }

            usuarioAEditar.Nombre = usuario.Nombre;
            usuarioAEditar.NumeroDocumento = usuario.NumeroDocumento;
            usuarioAEditar.Correo = usuario.Correo;
            usuarioAEditar.Direccion = usuario.Direccion;
            usuarioAEditar.FechaNacimiento = usuario.FechaNacimiento;
            usuarioAEditar.ProvinciaId = usuario.ProvinciaId;
            usuarioAEditar.Sexo = usuario.Sexo;

            try
            {
                _usuarioRepository.Actualizar(usuarioAEditar);
                return new ModeloRespuesta()
                {
                    HayError = false,
                };
            }
            catch (Exception ex) when (ex.InnerException is SqlException)
            {
                var codigo = (SqlException)ex.InnerException;
                if (codigo.Number == 2601)
                {
                    return new ModeloRespuesta()
                    {
                        HayError = true,
                        Error = "El DNI o Correo ya fueron registrados, no puede ingresar datos duplicados"
                    };
                }

                return new ModeloRespuesta()
                {
                    HayError = true,
                    Error = ex.Message.ToString()
                };
            }
            catch (Exception e)
            {
                return new ModeloRespuesta()
                {
                    HayError = true,
                    Error = e.Message.ToString()
                };
            }
        }

        public ModeloRespuesta Eliminar(int id)
        {
            var usuario = _usuarioRepository.ObtenerPorId(id);

            if (usuario is null)
            {
                return new ModeloRespuesta() { HayError = true, Error = "El usuario no existe en la base de datos"};
            }

            _usuarioRepository.Eliminar(usuario);
            return new ModeloRespuesta() { HayError = false, Error = ""};
        }

        public ObtenerUsuarioDTO ObtenerPorId(int id)
        {
            var usuario = _usuarioRepository.ObtenerPorId(id);

            if (usuario is null)
            {
                return default;
            }

            return new ObtenerUsuarioDTO()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                NumeroDocumento = usuario.NumeroDocumento,
                Correo = usuario.Correo,
                Direccion = usuario.Direccion,
                FechaNacimiento = usuario.FechaNacimiento,
                Sexo = usuario.Sexo,
                ProvinciaId = usuario.ProvinciaId,
            };
        }

        public List<ObtenerUsuarioDTO> ObtenerTodos()
        {
            var usuarios = _usuarioRepository.ObtenerTodos();
            var usuariosDto = new List<ObtenerUsuarioDTO>();

            foreach (var usuario in usuarios)
            {
                usuariosDto.Add(new ObtenerUsuarioDTO()
                {
                    Id = usuario.Id,
                    Nombre = usuario.Nombre,
                    FechaNacimiento = usuario.FechaNacimiento,
                    NumeroDocumento = usuario.NumeroDocumento,
                    Direccion = usuario.Direccion,
                    Correo = usuario.Correo,
                    Sexo = usuario.Sexo,
                    ProvinciaId = usuario.ProvinciaId
                });
            }

            return usuariosDto;
        }
    }
}
