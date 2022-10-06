using EmpresteFacil.Models.Entities;
using Microsoft.Extensions.WebEncoders.Testing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models.Entities
{
    [Table("PessoasFisicas")]
    public class PessoaFisica : Usuario
    {
        [Key]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O sobrenome deve ter entre 3 e 255 caracteres.")]
        public string Sobrenome { get; set; }

        [Display(Name = "Documento de identidade - RG")]
        public string Rg { get; set; }

        [Display(Name = "Grau de escolaridade")]
        public string GrauEscolaridade { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Tipo de usuário (comum/administrador)")]
        public bool Tipo { get; set; }

        public PessoaFisica(string cpf, string nome, string sobrenome, string rg, string grauEscolaridade, DateTime dataNascimento, bool tipo, int usuarioId, string email, string celular, string telefoneFixo)
            : base (usuarioId, email, celular, telefoneFixo)
        {
            Cpf = cpf;
            Nome = nome;
            Sobrenome = sobrenome;
            Rg = rg;
            GrauEscolaridade = grauEscolaridade;
            DataNascimento = dataNascimento;
            Tipo = tipo;
        }
    }
}
