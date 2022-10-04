using System;

namespace Emprestimo.Models.Entities
{ 
	public class Emprestimo
	{
		public int EmprestimoId { get; set; }
		public string TipoEmprestimo { get; set; }
		public double Valor { get; set; }
		public int NumeroParcelas { get; set; }
		public double TaxaJuros { get; set; }
		public DateTime DataInicioEmprestimo { get; set; }

		public Emprestimo()
		{

		}

		public Emprestimo (int emprestimoId, string tipoEmprestimo, double valor, int numeroParcelas, double taxaJuros, DateTime dataInicioEmprestimo)
		{
			EmprestimoId = EmpestimoId;
			TipoEmprestimo = tipoEmprestimo;
			Valor = valor;
			NumeroParcelas = numeroParcelas;
			TaxaJuros = taxaJuros;
			DataInicioEmprestimo = dataInicioEmprestimo;
		}
	}
}