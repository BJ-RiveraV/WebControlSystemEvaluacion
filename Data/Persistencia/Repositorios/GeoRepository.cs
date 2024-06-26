using Data.Data;
using Data.Interfaces.Repositorios;
using Data.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistencia.Repositorios
{
    public class GeoRepository : IGeoRepository
    {
        private readonly ApplicationDbContext _context;

        public GeoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = _context.Departamentos.Include(p => p.Provincias).ToList();

            return departamentos;
        }

        public List<Provincia> ObtenerProvinciasPorDepartamento(int id)
        {
            var provincias = _context.Provincias.Where(p => p.DepartamentoId == id).ToList();

            return provincias;
        }
    }
}
