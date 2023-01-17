using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DtoModels
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = String.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeleteBy { get; set; }
    }
}
