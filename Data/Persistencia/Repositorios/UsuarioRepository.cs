using Data.Data;
using Data.Interfaces.Repositorios;
using Data.Modelos;

namespace Data.Persistencia.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Actualizar(Usuario usuario)
        {
            _context.Users.Update(usuario);
            _context.SaveChanges();
        }

        public void Eliminar(Usuario usuario)
        {
            _context.Users.Remove(usuario);
            _context.SaveChanges();
        }

        public void Insertar(Usuario usuario)
        {
            _context.Users.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario ObtenerPorId(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _context.Users.ToList();
        }
    }
}
