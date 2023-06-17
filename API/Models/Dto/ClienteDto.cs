using System.ComponentModel.DataAnnotations;

namespace API.Models.Dto
{
    public class ClienteDto
    {
        public int idCliente { get; set; }
        [Required]
        [MaxLength(50)]

        public string? Name { get; set; }

        public double Peso { get; set; }
        public string? Medicamento { get; set; }

        public double Precio { get; set; }

        public string? Empresa { get; set; }
        public DateTime fechaCaducidad { get; set; }

        public int RazaId { get; set; }
    }
}
