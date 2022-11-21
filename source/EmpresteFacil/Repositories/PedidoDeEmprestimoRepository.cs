using EmpresteFacil.Context;

namespace EmpresteFacil.Repositories
{
    public class PedidoDeEmprestimoRepository
    {

        private readonly DatabaseContext _context;

        public PedidoDeEmprestimoRepository(DatabaseContext context)
        {
            _context = context;
        }
    }
}
