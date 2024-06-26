using Shared;

namespace HTTPClienteData.Interfaces
{
    public interface IClienteUsuarios
    {
        Task<ModeloRespuestaHTTP<List<ObtenerUsuarioDTO>>> ObtenerUsuarios();
        Task<ModeloRespuestaHTTP<string>> CrearUsuario(CreateUserDTO usuario);
        Task<ModeloRespuestaHTTP<string>> EditarUsuario(UpdateUserDTO usuario);
        Task<ModeloRespuestaHTTP<string>> EliminarUsuario(int id);
        Task<ModeloRespuestaHTTP<ObtenerUsuarioDTO>> ObtenerUsuario(int id);
    }
}
