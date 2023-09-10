using System.ComponentModel.DataAnnotations;

namespace WaCollaborative.Common.DTO
{
    public class CountryDTO
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public ICollection<StateDTO>? States { get; set; }

        [Display(Name = "Estados/Departamentos")]
        public int StatesNumber { get; set; }
    }
}