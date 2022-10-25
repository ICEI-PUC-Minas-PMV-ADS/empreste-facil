using EmpresteFacil.Context;
using EmpresteFacil.Repositories.Interfaces;
using System;

namespace EmpresteFacil.Repositories
{
    public class LoanRepository: ILoanRepository
    {

        private readonly DatabaseContext _context;

        public LoanRepository(DatabaseContext context)
        {
            _context = context;
        }
    }
}
