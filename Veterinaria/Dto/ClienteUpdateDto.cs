using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Dto
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

     
        public DateTime fechaCaducidad { get; set; }

        [Required]
        public int RazaId { get; set; }
    }
}
