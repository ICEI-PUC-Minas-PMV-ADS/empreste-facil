//using EmpresteFacil.Models.Enums;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace EmpresteFacil.Models.Entities
//{
//    [Table("Endereços")]
//    public class Endereco
//    {        
//        [Required(ErrorMessage = "Informe seu endereço")]
//        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
//        public string DescricaoLogradouro { get; set; }

//        [Required]
//        public string TipoLogradouro { get; set; }

//        [Required]
//        [StringLength(100, MinimumLength = 1, ErrorMessage = "O complemento deve ter entre 1 e 100 caracteres")]
//        public string Complemento { get; set; }

//        [Required]
//        [Display(Name = "Bairro")]
//        public string Bairro { get; set; }

//        [Required]
//        [Display(Name = "Cidade")]
//        public string Cidade { get; set; }

//        [Required]
//        [Display(Name = "Estado")]
//        public string Estado { get; set; }

//        [Required]
//        [Display(Name = "CEP")]
//        public string Cep { get; set; }

//        [Required]
//        [Display(Name = "Pais")]
//        public string? Pais { get; set; }
//    }
//}
