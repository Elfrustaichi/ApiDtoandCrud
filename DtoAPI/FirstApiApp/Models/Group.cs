using System.ComponentModel.DataAnnotations;

namespace FirstApiApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int TeacherId { get; set; }

        public List<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}
