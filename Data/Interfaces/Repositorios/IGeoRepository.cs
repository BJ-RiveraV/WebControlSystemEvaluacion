using Data.Modelos;

namespace Data.Interfaces.Repositorios
{
    public interface IGeoRepository
    {
        public List<Departamento> ObtenerDepartamentos();
        public List<Provincia> ObtenerProvinciasPorDepartamento(int id);
    }
}
