using EmpresteFacil.Context;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models
{
    [Table("Emprestimos")]
    public class Emprestimo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Valor do empréstimo")]
        public double ValorTotalEmprestimo { get; set; }

        [Display(Name = "Valor da parcela")]
        public double NumeroParcelas { get; set; }

        [Display(Name = "Taxa de juros")]
        public double TaxaJuros { get; set; }

        public Status Status { get; set; }
       
        public Usuario Usuario { get; set; }
    }

    public enum Status
    {
        [Display(Name = "Em análise")]
        EmAnalise,
        [Display(Name = "Aprovado")]
        Aprovado,
        [Display(Name = "Reprovado")]
        Reprovado
    }
}
