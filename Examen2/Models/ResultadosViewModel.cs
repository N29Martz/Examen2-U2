using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Examen2.Models
{
    public class ResultadosViewModel: IValidatableObject
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La cantidad de letras debe ser entre 3 y 50")]
        [Display(Name = "Nombre o Alias")]
        public string Nombre { get; set; }

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage ="El correo {0} es obligatorio")]
        [EmailAddress(ErrorMessage ="El campo {0} debe ser un correo valido")]
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Nombre != null && Nombre.Length > 0)
            {
                var primeraLetra = Nombre.ToString()[0].ToString();

                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser Mayuscula", new[] { nameof(Nombre) });
                }
            }
        }
    }
}
