using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Models;
using EmpresteFacil.Models.Entities;

namespace EmpresteFacil.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        //public DbSet<Installment>? Installments { get; set; }
        //public DbSet<LoanRequest>? LoanRequests { get; set; }

        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Parcelas> Parcelas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}