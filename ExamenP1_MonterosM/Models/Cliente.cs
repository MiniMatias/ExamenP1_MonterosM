using ExamenP1_MonterosM.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ExamenP1_MonterosM.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId
        {
            get; set;
        }
        [Required(ErrorMessage = "El nombre Completo es Obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        [Display(Name = "Nombre Completo")]


        public string NombreCompleto
        {
            get; set;
        }
        = string.Empty;


        [Required]
        [EmailAddress(ErrorMessage = "Ingrese una direccion de correo valida")]
        [Display(Name = "Correo Electronico")]
        public string Email
        {
            get; set;
        }
        = String.Empty;


        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2")]
        [Range(0,100000.00, ErrorMessage = "El saldo debe esta entre 0 y 100,000")]
        [Display(Name = "Saldo Cuenta")]
        public decimal SaldoCuenta
        {
            get; set;
        }


        [Display(Name = "Cliente Activo")]
        public bool EsActivo
        {
            get; set;
        }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro
        {
            get; set;
        }


        [Required(ErrorMessage = "El campo es obligatorio.")]
        [RegularExpression(@"^[A-Za-z]+S$", ErrorMessage = " El formato debe ser su nombre (Ej: MonterosM).")]
        [Display(Name = "Identificador Personalizado")]
        public string MonterosM
        {
            get; set;
        }
        = string.Empty;


        public virtual
            ICollection<Reserva>? Reservas
        {
            get; set;
        }


        public virtual PlanRecompensas? PlanRecompensas
        {
            get; set;
        }
    }
}
