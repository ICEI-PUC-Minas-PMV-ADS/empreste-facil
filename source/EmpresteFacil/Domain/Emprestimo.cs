using EmpresteFacil.Context;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models.Entities
{
    [Table("Emprestimos")]
    public class Emprestimo
    {
        [Key]
        public int EmprestimoId { get; set; }
        
        //public string TipoEmprestimo { get; set; }
        
        [Display(Name = "Valor do empréstimo")]
        [Column(TypeName = "decimal(10,2)")]
        public double ValorTotalEmprestimo { get; set; }
        
        [Display(Name = "Valor da parcela")]
        public int NumeroParcelas { get; set; }
        
        [Display(Name = "Taxa de juros")]
        [Column(TypeName = "decimal(4,2)")]
        public double TaxaJuros { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de início do empréstimo")]
        public DateTime DataInicioEmprestimo { get; set; }
        List<Parcelas> Parcelas { get; set; }

        //private readonly DatabaseContext _context;

        //public Emprestimo(DatabaseContext context)
        //{
        //    _context = context;
        //}
        //public bool PossoPedirEmprestimo(string idUsuario)
        //{
        //    if (idUsuario.Equals("123"))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
