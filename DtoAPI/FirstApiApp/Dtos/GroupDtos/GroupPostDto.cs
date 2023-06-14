using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Dtos.GroupDtos
{
    public class GroupPostDto
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
