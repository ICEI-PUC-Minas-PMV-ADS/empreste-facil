using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models.Entities
{
    [Table("PessoasFisicas")]
    public class PessoaFisica : Usuario
    {
        [StringLength(11)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "Sobrenome")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O sobrenome deve ter entre 3 e 255 caracteres.")]
        public string Sobrenome { get; set; }

        [Display(Name = "Documento de identidade - RG")]
        [StringLength(20)]
        public string Rg { get; set; }

        [Display(Name = "Grau de escolaridade")]
        [StringLength(50)]
        public string GrauEscolaridade { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        
    }
}
