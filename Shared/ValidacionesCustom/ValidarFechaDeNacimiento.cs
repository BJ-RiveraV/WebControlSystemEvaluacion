using System.ComponentModel.DataAnnotations;

namespace Shared.ValidacionesCustom
{
    public class ValidarFechaDeNacimiento : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var fecha = (DateTime)value;

            if (fecha >= DateTime.Now.AddDays(-1))
            {
                return new ValidationResult("La Fecha de Nacimiento no puede ser igual o mayor a la fecha actual");
            }

            return ValidationResult.Success;
        }
    }
}
