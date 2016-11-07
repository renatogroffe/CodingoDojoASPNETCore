using Microsoft.EntityFrameworkCore;

namespace CodingoDojoASPNETCore.Data
{
    public class CotacoesContext : DbContext
    {
        public DbSet<Cotacao> Cotacoes { get; set; }

        public CotacoesContext(DbContextOptions<CotacoesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cotacao>().HasKey(c => c.Sigla);
        }
    }
}