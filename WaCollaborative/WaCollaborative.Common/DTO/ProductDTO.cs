using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Common.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Code { get; set; } = null!;

        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; } = null!;        

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "FactorConversión ")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal ConversionFactor { get; set; }

        public Category? Category { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int CategoryId { get; set; }

        public Segment? Segment { get; set; }

        [Display(Name = "Segmento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int SegmentId { get; set; }

        public MeasurementUnit? MeasurementUnit { get; set; }

        [Display(Name = "Unidad de Medida")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int MeasurementUnitId { get; set; }
    }
}