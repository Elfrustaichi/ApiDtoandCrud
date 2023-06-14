using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Dtos.StudentDtos
{
    public class StudentPostDto
    {
        [Required]
        [MaxLength(25)]
        public string FullName { get; set; }
        [Required]
        public int GroupId { get; set; }
    }
}
