using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmpresteFacil.Models.Entities
{
    public class PessoaJuridica : Usuario
    {
        [Key]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Informe a razão social.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "A razão social deve ter entre 3 e 255 caracteres.")]
        public string RazaoSocial { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss tt}")]
        [Display(Name = "Data de constituição ou início das atividades")]
        public DateTime DataConstituicao { get; set; }

        public PessoaJuridica(string cnpj, string razaoSocial, DateTime dataConstituicao, int usuarioId, string email, string celular, string telefoneFixo)
            : base (usuarioId, email, celular, telefoneFixo)
        {
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            DataConstituicao = dataConstituicao;
        }
    }
}
