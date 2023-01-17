using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DtoModels
{
    public class User: BaseEntity
    {
        [Required, StringLength(50)]
        public string? Name { get; set; }
        [Required, StringLength(60)]
        public string? LastName { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Passwd { get; set; }

    }
}
