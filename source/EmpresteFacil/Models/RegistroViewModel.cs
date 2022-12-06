using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmpresteFacil.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Informe uma senha")]
        [Display(Name = "Senha, certifique-se de colocar letras maiúsculas, números e símbolos. *")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Informe um email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o telefone celular.")]
        [DisplayName("Telefone celular*")]
        [DataType(DataType.PhoneNumber)]
        public string? Celular { get; set; }

        [DisplayName("Telefone fixo* ")]
        [DataType(DataType.PhoneNumber)]
        public string? TelefoneFixo { get; set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "O RG deve ter ao menos 3 caracteres.")]
        [Display(Name = "Documento de identidade - RG * ")]
        public string RG { get; set; }

        [Required]
        [Display(Name = "Documento de identidade - CPF/CNPJ*")]
        public string Document { get; set; }


        public Perfil Perfil { get; set; }

    }
}
