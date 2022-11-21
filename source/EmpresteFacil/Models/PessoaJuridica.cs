using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace EmpresteFacil.Models
{
    [Table("PessoasJuridicas")]
    public class PessoaJuridica : Usuario
    {
        [StringLength(14)]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Informe a razão social.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "A razão social deve ter entre 3 e 255 caracteres.")]
        public string RazaoSocial { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido")]
        [Display(Name = "Data de constituição ou início das atividades")]
        public DateTime DataConstituicao { get; set; }
    }
}
