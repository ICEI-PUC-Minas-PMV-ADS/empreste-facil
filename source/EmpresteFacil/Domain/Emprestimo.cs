using System;

class Emprestimo
{
	public int IdEmprestimo { get; set; }
	public string TipoEmprestimo { get; set; }
	public double Valor { get; set; }
	public int NumeroParcelas { get; set; }
	public double TaxaJuros { get; set; }
	public DateTime DataInicioEmprestimo { get; set; }

	public Emprestimo()
	{

	}

	public Emprestimo (int idEmpestimo, string tipoEmprestimo, double valor, int numeroParcelas, double taxaJuros, DateTime dataInicioEmprestimo)
	{
		IdEmprestimo = idEmpestimo;
		TipoEmprestimo = tipoEmprestimo;
		Valor = valor;
		NumeroParcelas = numeroParcelas;
		TaxaJuros = taxaJuros;
		DataInicioEmprestimo = dataInicioEmprestimo;
	}
}
