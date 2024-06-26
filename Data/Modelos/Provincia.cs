namespace Data.Modelos
{
    public class Provincia
    {
        public int Id { get; set; }

        public int DepartamentoId { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
