using System.ComponentModel.DataAnnotations;

namespace API.Models.Dto
{
    public class RazaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]

        public string RazaName { get; set; }
    }
}
