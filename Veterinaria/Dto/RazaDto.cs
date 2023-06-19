using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Dto
{
    internal class RazaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]

        public string RazaName { get; set; }
    }
}
