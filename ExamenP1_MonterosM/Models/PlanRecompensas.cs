using ExamenP1_MonterosM.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ExamenP1_MonterosM.Models
{
    public class PlanRecompensas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre del Plan")]
        public string Nombre { get; set; } = "Plan Básico";

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Los puntos no pueden ser negativos.")]
        [Display(Name = "Puntos Acumulados")]
        public int PuntosAcumulados { get; set; } = 0;

        [NotMapped]
        [Display(Name = "Tipo de Recompensa")]
        public string TipoRecompensa => PuntosAcumulados < 500 ? "SILVER" : "GOLD";

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente? Cliente { get; set; }
    } 

}