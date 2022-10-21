using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int LoanRequestId { get; set; }
        [Required]
        public int ApproverId { get; set; }
        [Required]
        public string? State { get; set; }
    }
}
