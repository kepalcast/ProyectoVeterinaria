using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Dto
{
    internal class RazaCreateDto
    {
        [Required]
        [StringLength(50)]
        public string RazaName { get; set; }
    }
}
