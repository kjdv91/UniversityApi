using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DtoModels
{
    public class Student: BaseEntity
    {
        [Required]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string LastName { get; set; } = String.Empty;
        [Required]
        public DateTime DateBirthd { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
