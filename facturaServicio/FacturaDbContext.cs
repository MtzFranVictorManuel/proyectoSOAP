using Microsoft.EntityFrameworkCore;

namespace FacturaDbContextNamespace
{
    public class FacturaDbContext : DbContext
    {
        public FacturaDbContext(DbContextOptions<FacturaDbContext> options) : base(options) { }

        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>().ToTable("Factura");
        }
    }
}