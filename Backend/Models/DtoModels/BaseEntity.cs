using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DtoModels
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public int UserID { get; set; }  //relacion
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual User CreatedBy { get; set; } = new User(); 
        public DateTime? UpdatedAt { get; set; }
        public User UpdateBy { get; set; } = new User();
        public DateTime? DeletedAt { get; set; }
        public User DeleteBy { get; set; } = new User();
    }
}
