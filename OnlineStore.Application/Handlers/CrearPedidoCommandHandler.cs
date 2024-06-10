using MediatR;
using OnlineStore.Application.Commands;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.Application.Handlers
{
    
    /// Manejador para el comando de crear un Pedido.
    
    public class CrearPedidoCommandHandler : IRequestHandler<CrearPedidoCommand, long>
    {
        private readonly IPedidoRepository _pedidoRepository;

        
        /// Inicializa una nueva instancia del manejador de comando para crear un Pedido.
        
        /// Repositorio de Pedidos.
        public CrearPedidoCommandHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        
        /// Maneja el comando para crear un Pedido.
        
        /// Comando para crear un Pedido.
        /// Token de cancelación.
        /// Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el identificador único del Pedido creado.
        public async Task<long> Handle(CrearPedidoCommand request, CancellationToken cancellationToken)
        {
            var pedido = new Pedido(request.Descripcion);
            await _pedidoRepository.AddAsync(pedido);
            return pedido.Id;
        }
    }
}
