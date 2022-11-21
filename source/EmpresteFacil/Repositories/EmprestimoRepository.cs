using EmpresteFacil.Context;
using EmpresteFacil.Repositories.Interfaces;
using System;

namespace EmpresteFacil.Repositories
{
    public class EmprestimoRepository: ILoanRepository
    {

        private readonly DatabaseContext _context;

        public EmprestimoRepository(DatabaseContext context)
        {
            _context = context;
        }
    }
}
