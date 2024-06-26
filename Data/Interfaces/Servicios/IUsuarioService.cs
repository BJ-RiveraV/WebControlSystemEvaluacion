using Shared;

namespace Data.Interfaces.Servicios
{
    public interface IUsuarioService
    {
        public ModeloRespuesta Agregar(CreateUserDTO usuario);

        public ModeloRespuesta Editar(UpdateUserDTO usuario);

        public List<ObtenerUsuarioDTO> ObtenerTodos();

        public ObtenerUsuarioDTO ObtenerPorId(int id);

        public ModeloRespuesta Eliminar(int id);
    }
}
