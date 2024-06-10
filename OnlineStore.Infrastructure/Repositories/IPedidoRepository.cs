using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Repositories
{
    
    /// Interfaz para el repositorio de Pedidos.
    
    public interface IPedidoRepository
    {
        
        /// Agrega asincrónicamente un nuevo Pedido a la base de datos.
        
        /// El Pedido que se agregará.
        /// Una tarea que representa la operación asincrónica.
        Task AddAsync(Pedido pedido);

        
        /// Recupera asincrónicamente todas las entidades Pedido de la base de datos.
        
        /// Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una lista de Pedidos.
        Task<List<Pedido>> GetAllAsync();
    }
}
