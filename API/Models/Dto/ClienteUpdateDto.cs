using System.ComponentModel.DataAnnotations;

namespace API.Models.Dto
{
    public class ClienteUpdateDto
    {
        [Required]
        public int idCliente { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public double Pesokg { get; set; }
        [Required]
        public string? Medicamento { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public string? Empresa { get; set; }

        [Required]
        public int AñodeCaducidad { get; set; }

        [Required]
        public int RazaId { get; set; }
    }
}
