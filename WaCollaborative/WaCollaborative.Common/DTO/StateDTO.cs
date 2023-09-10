using System.ComponentModel.DataAnnotations;

namespace WaCollaborative.Common.DTO
{
    public class StateDTO
    {
        public int Id { get; set; }

        [Display(Name = "Estado / Departamento")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public int CountryId { get; set; }

        public CountryDTO? Country { get; set; }

        public ICollection<CityDTO>? Cities { get; set; }

        [Display(Name = "Ciudades")]
        public int CitiesNumber { get; set; }
    }
}