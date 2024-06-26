using Data.Modelos;

namespace Data.Interfaces.Repositorios
{
    public interface IUsuarioRepository
    {
        public void Insertar(Usuario usuario);

        public void Actualizar(Usuario usuario);

        public void Eliminar(Usuario usuario);

        public Usuario ObtenerPorId(int id);

        public List<Usuario> ObtenerTodos();
    }
}
