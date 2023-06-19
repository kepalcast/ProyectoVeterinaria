using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Dto
{
    internal class RazaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string RazaName { get; set; }
    }
}
