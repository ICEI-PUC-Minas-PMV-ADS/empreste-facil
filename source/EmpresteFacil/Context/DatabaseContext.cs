using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using EmpresteFacil.Models.Entities;

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
        public DbSet<Score>? Scores { get; set; }
        public DbSet<Emprestimo>? Emprestimos { get; set; }
        public DbSet<Parcelas> Parcelas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }

    }

}