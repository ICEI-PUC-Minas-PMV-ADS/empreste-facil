using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EmpresteFacil.Models
{
    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "Informe um nome")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "O nome deve ter ao menos 2 caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [AllowNull]
        [DisplayName("Telefone fixo")]
        [DataType(DataType.PhoneNumber)]
        public string? TelefoneFixo { get; set; }

        public Perfil Perfil { get; set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "O RG deve ter ao menos 3 caracteres.")]
        [Display(Name = "Documento de identidade - RG")]
        public string RG { get; set; }

        [Required]
        [Display(Name = "Documento de identidade - CPF/CNPJ*")]
        public string Document { get; set; }

    }

    public enum Perfil
    {
        [Display(Name ="Pessoa física")]
        PessoaFisica,
        [Display(Name = "Pessoa jurídica")]
        PessoaJuridica
    }
}
