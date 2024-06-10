using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Persistence;

namespace OnlineStore.Infrastructure.Repositories
{
    
    /// Repositorio para gestionar entidades Pedido en la base de datos.
   
    public class PedidoRepository : IPedidoRepository
    {
        private readonly OnlineStoreDbContext _context;

        
        /// Inicializa una nueva instancia de la clase PedidoRepository.
        
        /// El contexto de base de datos que utilizará el repositorio
        public PedidoRepository(OnlineStoreDbContext context)
        {
            _context = context;
        }

        
        /// Agrega asincrónicamente un nuevo Pedido a la base de datos.
       
        /// La entidad Pedido que se agregará.
        /// Una tarea que representa la operación asincrónica.
        public async Task AddAsync(Pedido pedido)
        {
            // Agrega la entidad Pedido al DbContext.
            _context.Pedidos.Add(pedido);

            // Guarda los cambios asincrónicamente en la base de datos.
            await _context.SaveChangesAsync();
        }

        
        /// Recupera asincrónicamente todas las entidades Pedido de la base de datos.
        
        /// Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una lista de entidades Pedido.
        public async Task<List<Pedido>> GetAllAsync()
        {
            // Recupera todas las entidades Pedido de la base de datos y las devuelve como una lista.
            return await _context.Pedidos.ToListAsync();
        }
    }
}
