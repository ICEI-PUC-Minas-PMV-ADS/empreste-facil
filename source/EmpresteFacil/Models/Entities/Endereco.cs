namespace EmpresteFacil.Models.Entities
{
    class Endereco
    {
        public string TipoLogradouro { get; set; }
        public string DescricaoLogradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }

        public Endereco()
        {
        }

        public Endereco(string tipoLogradouro, string descricaoLogradouro, string complemento, string bairro, string cidade, string estado, string cep, string pais)
        {
            TipoLogradouro = tipoLogradouro;
            DescricaoLogradouro = descricaoLogradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Pais = pais;
        }
    }
}
