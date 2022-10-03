using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = new Guid();
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; } = null;

    }
}
