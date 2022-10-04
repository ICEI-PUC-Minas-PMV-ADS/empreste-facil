using System;
using System.Models.Enums;

namespace Parcelas.Models.Entities
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
		public double Amortizacao { get; set; }
		public StatusParcela StatusParcela { get; set; } //NÃO ESTÁ PUXANDO DE EMPRESTIMO
	}
}
