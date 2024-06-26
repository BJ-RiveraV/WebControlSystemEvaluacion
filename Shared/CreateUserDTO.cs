using Shared.ValidacionesCustom;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class CreateUserDTO
    {
        [MaxLength(50, ErrorMessage = "El Nombre no puede contener mas de 50 caracteres")]
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La Fecha de nacimiento es obligatoria")]
        [DisplayName("Fecha de Nacimiento")]
        [ValidarFechaDeNacimiento]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now.AddDays(-1).Date;

        [RegularExpression(@"^\d{8}$", ErrorMessage = "El DNI es obligatorio y debe contar con 8 caracteres")]
        [Required(ErrorMessage = "El DNI es obligatorio")]
        [DisplayName("DNI")]
        public long NumeroDocumento { get; set; }

        [MaxLength(50, ErrorMessage = "La direccion no puede contener mas de 50 caracteres")]
        [Required(ErrorMessage = "La dirección es obligatoria")]
        [DisplayName("Dirección")]
        public string Direccion { get; set; } = string.Empty;


        [EmailAddress(ErrorMessage = "Debe ingresar un email valido")]
        [Required(ErrorMessage = "El Correo es obligatorio")]
        public string Correo { get; set; } = string.Empty;

        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "La Provincia es obligatoria")]
        [DisplayName("Provincia")]
        [Required(ErrorMessage = "Debe seleccionar una provincia")]
        public int ProvinciaId { get; set; } = 0;

        [Required(ErrorMessage = "El sexo es obligatorio")]
        public bool Sexo { get; set; } = true;

        [Required(ErrorMessage = "Debe seleccionar un departamento")]
        public int DepartamentoId { get; set; } = 0;
    }
}
