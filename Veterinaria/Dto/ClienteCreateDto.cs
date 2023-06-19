using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Dto
{
    public class ClienteCreateDto
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public double Pesokg { get; set; }
        public string? Medicamento { get; set; }

        public double Precio { get; set; }

        public string? Empresa { get; set; }
        public int AñodeCaducidad { get; set; }

        public int RazaId { get; set; }
    }
}
