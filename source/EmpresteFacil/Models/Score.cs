using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Id do Usuário")]
        [Required]
        public string? UserId { get; set; }
        [Required]
        [Display(Name = "Valor do empréstimo")]
        public decimal Value { get; set; }
    }
}
