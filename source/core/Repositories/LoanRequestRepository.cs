using EmpresteFacil.Context;

namespace EmpresteFacil.Repositories
{
    public class LoanRequestRepository
    {

        private readonly DatabaseContext _context;

        public LoanRequestRepository(DatabaseContext context)
        {
            _context = context;
        }
    }
}
