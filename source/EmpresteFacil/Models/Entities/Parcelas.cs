using EmpresteFacil.Models.Enums;

namespace EmpresteFacil.Models.Entities
{
    public class Parcelas : Emprestimo
    {
        public int IdParcela { get; set; }
        public double ValorParcela { get; set; }
        public DateTime DataParcela { get; set; }
        public double Juros { get; set; }
        public double Amortizacao { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorMulta { get; set; }
        public StatusParcela StatusParcela { get; set; }

        public Parcelas()
        {
        }

        public Parcelas(int idParcela, double valorParcela, DateTime dataParcela, double juros, double amortizacao, DateTime dataPagamento, double valorMulta, StatusParcela statusParcela)
        {
            IdParcela = idParcela;
            ValorParcela = valorParcela;
            DataParcela = dataParcela;
            Juros = juros;
            Amortizacao = amortizacao;
            DataPagamento = dataPagamento;
            ValorMulta = valorMulta;
            StatusParcela = statusParcela;
        }
    }


}
