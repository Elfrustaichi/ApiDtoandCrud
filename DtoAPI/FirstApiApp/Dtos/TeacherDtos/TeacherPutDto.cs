using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Dtos.TeacherDtos
{
    public class TeacherPutDto
    {
        [MaxLength(100)]        
        
        public string Fullname { get; set; }
    }
}
