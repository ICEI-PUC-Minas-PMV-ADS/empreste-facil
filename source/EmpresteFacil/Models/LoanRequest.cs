using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class LoanRequest
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Id do Usuário")]
        [Required]
        public string? UserId { get; set; }
        [Display(Name = "Data de aprovação")]
        public DateTime? ApprovedAt { get; set; }

        [Required]
        [Display(Name = "Valor do empréstimo")]
        public decimal Value { get; set; }

        [Required]
        [Display(Name = "Status do empréstimo")]
        public bool Approved { get; set; } = false;
    }
}
