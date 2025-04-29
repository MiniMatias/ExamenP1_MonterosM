using ExamenP1_MonterosM.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenP1_MonterosM.Models
{
    public class Reserva : IValidatableObject
    {
        [Key]
        public int ReservaId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Entrada")]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Salida")]
        public DateTime FechaSalida { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 10000.00, ErrorMessage = "El valor debe ser mayor a 0 y menor o igual a 10,000.")]
        [Display(Name = "Valor a Pagar")]
        public decimal ValorAPagar { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un cliente.")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente? Cliente { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FechaSalida <= FechaEntrada)
            {
                yield return new ValidationResult(
                    "La fecha de salida debe ser posterior a la fecha de entrada.",
                    new[] { nameof(FechaSalida) });
            }
        }

    }
}