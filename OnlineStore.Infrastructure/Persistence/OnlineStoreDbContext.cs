using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Persistence
{
   
    /// DbContext para la tienda en línea.
    
    public class OnlineStoreDbContext : DbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
            : base(options)
        {
        }

        
        /// DbSet para la entidad Pedido.
        
        public DbSet<Pedido> Pedidos { get; set; }

        
        /// Configuración del modelo de datos.
        
        /// Constructor de modelos para configurar las entidades y relaciones.
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
