using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }
        [Required]
        public string? Name { get; set; }

        public double Pesokg { get; set; }    
        public string? Medicamento { get; set; }

        public double Precio { get; set; }

        public string? Empresa { get; set; }
        public int AñodeCaducidad { get; set; }

        public int RazaId { get; set; }
        [ForeignKey("RazaId")]
        public Raza Raza { get; set; }





    }
}
