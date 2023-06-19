using System.ComponentModel.DataAnnotations;

namespace API.Models.Dto
{
    public class RazaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string RazaName { get; set; }
    }
}
