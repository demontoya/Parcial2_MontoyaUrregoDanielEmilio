using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_MontoyaUrregoDanielEmilio.DAL.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime? UseDate { get; set; }
        public bool? IsUsed { get; set; }
        public string? EntranceGate { get; set; }

    }
}
