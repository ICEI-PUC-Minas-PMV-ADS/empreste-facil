using System;

class PessoaFisica : Usuario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string GrauEscolaridade { get; set; }
    public DateTime DataNascimento { get; set; }
    public bool Tipo { get; set; }

    public PessoaFisica()
    {

    }

    public PessoaFisica(string nome, string sobrenome, string cpf, string rg, string grauEscolaridade, DateTime dataNascimento, bool tipo)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Cpf = cpf;
        Rg = rg;
        GrauEscolaridade = grauEscolaridade;
        Tipo = tipo;
    }
}
