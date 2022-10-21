using System;

class PessoaJuridica : Usuario
{
	public string RazaoSocial { get; set; }
	public string CNPJ { get; set; }
	public DateTime DataConstituicao { get; set; }

	public PessoaJuridica()
	{

	}

	public PessoaJuridica(string razaoSocial, string cnpj, DateTime dataConstituicao) 
	{
		RazaoSocial = razaoSocial;
		CNPJ = cnpj;
		DataConstituicao = dataConstituicao;
	}



}
