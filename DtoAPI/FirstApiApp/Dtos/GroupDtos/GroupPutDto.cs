using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Dtos.GroupDtos
{
    public class GroupPutDto
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
