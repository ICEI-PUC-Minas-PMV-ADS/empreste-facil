using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class Loan : BaseModel
    {
        public int UserId { get; set; }
        public int ApproverId { get; set; }
        public string? State { get; set; }
    }
}
