using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models
{
    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        
        [DisplayName("Telefone fixo")]
        [DataType(DataType.PhoneNumber)]
        public string? TelefoneFixo { get; set; }

        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        [Display(Name ="Pessoa física")]
        Pessoa_Fisica,
        [Display(Name = "Pessoa jurídica")]
        Pessoa_Juridica
    }
}
