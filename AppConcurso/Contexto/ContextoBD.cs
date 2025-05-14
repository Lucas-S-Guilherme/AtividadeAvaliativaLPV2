using AppConcurso.Models;
using Microsoft.EntityFrameworkCore;


namespace AppConcurso.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options) { }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Candidato)
                .WithMany(c => c.Inscricoes)
                .HasForeignKey(i => i.CandidatoIdFk);

            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Cargo)
                .WithMany(c => c.Inscricoes)
                .HasForeignKey(i => i.CargoIdFk);
        }
    }
}
