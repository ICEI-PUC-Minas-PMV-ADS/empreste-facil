using EmpresteFacil.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models
{
    [Table("Parcelas")]
    public class Parcelas
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Valor da parcela")]
        public decimal ValorParcela { get; set; }

        [Display(Name = "Data de vencimento da parcela")]
        public DateTime DataVencimentoParcela { get; set; }

        [Display(Name = "Valor dos juros")]
        public decimal Juros { get; set; }

        [Display(Name = "Valor da amortização")]
        public decimal Amortizacao { get; set; }

        //[DataType(DataType.DateTime)]
        [Display(Name = "Data de pagamento")]
        public DateTime DataPagamento { get; set; }

        [Display(Name = "Valor da multa")]
        public decimal ValorMulta { get; set; }

        [Display(Name = "Situação da parcela")]
        public StatusParcela StatusParcela { get; set; }

        public Emprestimo Emprestimo { get; set; }
    }

    public enum StatusParcela
    {
        Quitada,
        Atrasada,
        PagaComAtraso
    }
}
