using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Domain.Models;
using ProjetoLoja.Infra.Data.EF.Maps;

namespace ProjetoLoja.Infra.Data.EF
{
    public class ProdutoLojaContext : DbContext
    {
        public ProdutoLojaContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}