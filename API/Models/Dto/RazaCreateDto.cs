using System.ComponentModel.DataAnnotations;

namespace API.Models.Dto
{
    public class RazaCreateDto
    {
        [Required]
        [StringLength(50)]
        public string RazaName { get; set; }
    }
}
