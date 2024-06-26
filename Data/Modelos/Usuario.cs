namespace Data.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public long NumeroDocumento { get; set; }

        public int ProvinciaId { get; set; }

        public string Direccion { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public bool Sexo { get; set; }
    }
}
