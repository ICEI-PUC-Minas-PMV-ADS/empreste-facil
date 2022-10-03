using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Models;

namespace EmpresteFacil.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Installment>? Installments { get; set; }
        public DbSet<LoanRequest>? LoanRequests { get; set; }
    }
}