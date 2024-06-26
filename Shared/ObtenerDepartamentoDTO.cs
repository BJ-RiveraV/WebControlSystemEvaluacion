namespace Shared
{
    public class ObtenerDepartamentoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public List<ObtenerProvinciaDTO> Provincias { get; set; } = new List<ObtenerProvinciaDTO>();
    }
}
