using MediatR;

namespace OnlineStore.Application.Commands
{
    
    /// Comando para crear un Pedido.
    
    public class CrearPedidoCommand : IRequest<long>
    {
        
        /// Descripción del Pedido.
        
        public string Descripcion { get; set; }

        
        /// Inicializa una nueva instancia del comando para crear un Pedido con la descripción dada.
        
        /// Descripción del Pedido.
        public CrearPedidoCommand(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
