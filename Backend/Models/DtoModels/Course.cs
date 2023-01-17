using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DtoModels
{
    public class Course: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(280)]
        public string DescriptionShort { get; set; }
        [Required, StringLength(400)]
        public string? DescriptionLong { get; set; }
        public string Objects { get; set; }
        public int Requiremments { get; set; }
        
        public enum Level
        {
            Basic,
            Intermediate,
            Advanced



        }
    }
}
