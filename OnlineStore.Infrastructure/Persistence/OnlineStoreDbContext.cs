using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Persistence
{
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("Pedido");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Descripcion).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Estado).IsRequired().HasMaxLength(50);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
