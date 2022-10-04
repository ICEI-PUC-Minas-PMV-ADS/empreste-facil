namespace EmpresteFacil.Models.Entities
{
    public class Usuario
    {
        public int CodUsuario { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string TelefoneFixo { get; set; }

        public Usuario()
        {
        }

        public Usuario(int codUsuario, string email, string celular, string telefoneFixo)
        {
            CodUsuario = codUsuario;
            Email = email;
            Celular = celular;
            TelefoneFixo = telefoneFixo;
        }
    }
}
