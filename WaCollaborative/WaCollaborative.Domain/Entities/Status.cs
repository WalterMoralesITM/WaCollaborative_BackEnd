namespace WaCollaborative.Domain.Entities
{
    #region Import

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    #endregion Import

    /// <summary>
    /// The class entity Status
    /// </summary>

    [Table("Status", Schema = "Parameters")]
    public class Status
    {
        #region Attributes

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nombre Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Nombre Corto Estado")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Shortname { get; set; }

        #endregion Attributes
    }
}