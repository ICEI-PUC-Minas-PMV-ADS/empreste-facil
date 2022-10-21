using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EmpresteFacil.Context
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Installment>? Installments { get; set; }
        public DbSet<LoanRequest>? LoanRequests { get; set; }
    }
}