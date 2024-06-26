using Data.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Data.Seed
{
    public class DepartamentosSeed : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                new Departamento()
                {
                    Id = 1,
                    Nombre = "Amazonas",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 2,
                    Nombre = "Ancash",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 3,
                    Nombre = "Apurímac",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 4,
                    Nombre = "Arequipa",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 5,
                    Nombre = "Ayacucho",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 6,
                    Nombre = "Cajamarca",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 7,
                    Nombre = "Callao",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 8,
                    Nombre = "Cusco",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 9,
                    Nombre = "Huancavelica",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 10,
                    Nombre = "Huánuco",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 11,
                    Nombre = "Ica",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 12,
                    Nombre = "Junín",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 13,
                    Nombre = "La Libertad",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 14,
                    Nombre = "Lambayeque",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 15,
                    Nombre = "Lima",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 16,
                    Nombre = "Loreto",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 17,
                    Nombre = "Madre de Dios",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 18,
                    Nombre = "Moquegua",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 19,
                    Nombre = "Pasco",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 20,
                    Nombre = "Piura",
                    Provincias = new List<Provincia>()
                },
                new Departamento()
                {
                    Id = 21,
                    Nombre = "Puno",
                    Provincias = new List<Provincia>()
                }
            );
        }
    }
}
