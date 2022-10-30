using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.ViewModels
{
    public class HelpViewModel
    {
        [Display(Name = "Seu nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Seu email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Seu telefone")]
        [Required]
        public string Telefone { get; set; }

        [Display(Name = "Digite sua mensagem")]
        [Required]
        public string Mensagem { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
