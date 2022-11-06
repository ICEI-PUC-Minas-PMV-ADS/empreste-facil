using EmpresteFacil.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.Models.Entities
{
    [Table("Parcelas")]
    public class Parcelas
    {
        [Key]
        public int ParcelaId { get; set; }

        [Display(Name = "Valor da parcela")]
        [Column(TypeName = "decimal(10,2)")]
        public double ValorParcela { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de vencimento da parcela")]
        public DateTime DataVencimentoParcela { get; set; }

        [Display(Name = "Valor dos juros")]
        [Column(TypeName = "decimal(4,2)")]
        public double Juros { get; set; }

        [Display(Name = "Valor da amortização")]
        [Column(TypeName = "decimal(10,2)")]
        public double Amortizacao { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de pagamento")]
        public DateTime DataPagamento { get; set; }

        [Display(Name = "Valor da multa")]
        [Column(TypeName = "decimal(10,2)")]
        public double ValorMulta { get; set; }

        [Display(Name = "Situação da parcela")]
        public StatusParcela StatusParcela { get; set; }

        public int EmprestimoId { get; set; }
        public virtual Emprestimo Emprestimo { get; set; }
    }

    public enum StatusParcela
    {
        Quitada,
        Atrasada,
        PagaComAtraso
    }
}
