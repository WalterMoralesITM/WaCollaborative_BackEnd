using System.ComponentModel.DataAnnotations;

namespace WaCollaborative.Common.DTO
{
    public class CityDTO
    {
        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public int StateId { get; set; }

        public StateDTO? State { get; set; }
    }
}