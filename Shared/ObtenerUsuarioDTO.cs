namespace Shared
{
    public class ObtenerUsuarioDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public long NumeroDocumento { get; set; }

        public string Direccion { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public int ProvinciaId { get; set; }

        public bool Sexo { get; set; } = true;
    }
}
