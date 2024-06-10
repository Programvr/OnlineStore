using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Events
{
    
    /// Evento que representa la creación de un Pedido.
    
    public class PedidoCreado
    {
        
        /// Pedido creado.
        
        public Pedido Pedido { get; }

        
        /// Inicializa una nueva instancia de la clase PedidoCreado.
        
        /// El Pedido que se ha creado.
        public PedidoCreado(Pedido pedido)
        {
            Pedido = pedido;
        }
    }
}
