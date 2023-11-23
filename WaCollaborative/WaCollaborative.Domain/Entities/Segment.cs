using System.ComponentModel.DataAnnotations;

namespace WaCollaborative.Domain.Entities
{
    public class Segment
    {
        public int Id { get; set; }

        [Display(Name = "Segmento")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; } = null!;

        public ICollection<Product>? Products { get; set; }
    }
}