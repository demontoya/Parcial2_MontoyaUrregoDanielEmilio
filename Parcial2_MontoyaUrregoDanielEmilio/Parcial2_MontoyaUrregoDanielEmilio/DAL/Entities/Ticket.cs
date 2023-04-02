using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_MontoyaUrregoDanielEmilio.DAL.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Numero Ticket")]
        public int Id { get; set; }
        [Display(Name = "Fecha de uso")]
        public DateTime? UseDate { get; set; }
        [Display(Name = "Estado uso")]
        public bool? IsUsed { get; set; }
        [Display(Name = "Puerta de entrada")]
        public string? EntranceGate { get; set; }

    }
}
