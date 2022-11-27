using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [Display(Name = "Senha")]
        public string? Password { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
