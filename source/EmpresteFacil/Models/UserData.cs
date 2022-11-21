using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models
{
    [Table("UserData")]
    public class UserData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O sobrenome deve ter entre 3 e 255 caracteres.")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Documento de identidade - RG")]
        public string Rg { get; set; }

        [Required]
        [Display(Name = "Documento de identidade - CPF")]
        public string Cpf { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Address { get; set; }
    }
}
