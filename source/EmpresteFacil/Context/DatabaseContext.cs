using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EmpresteFacil.Context
{
    public class DatabaseContext : IdentityDbContext<Usuario>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<PedidoDeEmprestimo>? PedidoDeEmprestimo { get; set; }
        public DbSet<Score>? Scores { get; set; }
        public DbSet<Parcelas>? Parcelas { get; set; }
        public DbSet<Emprestimo>? Emprestimos { get; set; }

    }

}