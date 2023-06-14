using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Dtos.TeacherDtos
{
    public class TeacherPostDto
    {
        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

       
    }
}
