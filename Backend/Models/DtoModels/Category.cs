using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DtoModels
{
    public class Category: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
