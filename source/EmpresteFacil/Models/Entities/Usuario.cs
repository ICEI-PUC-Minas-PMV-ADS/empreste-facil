using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models.Entities
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Preencha o email")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O email deve ter entre 3 e 255 caracteres.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o telefone")]
        [DisplayName("Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Preencha o telefone")]
        [DisplayName("Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string TelefoneFixo { get; set; }
    }
}
