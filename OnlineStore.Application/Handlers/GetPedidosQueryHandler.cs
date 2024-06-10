using MediatR;
using OnlineStore.Application.Queries;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.Application.Handlers
{
    
    /// Manejador para la consulta de obtener todos los Pedidos.
    
    public class GetPedidosQueryHandler : IRequestHandler<GetPedidosQuery, List<Pedido>>
    {
        private readonly IPedidoRepository _pedidoRepository;

        
        /// Inicializa una nueva instancia del manejador de la consulta de obtener todos los Pedidos.
        
        /// Repositorio de Pedidos.
        public GetPedidosQueryHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        
        /// Maneja la consulta para obtener todos los Pedidos.
        
        /// Consulta para obtener todos los Pedidos.
        /// Token de cancelación.
        /// Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una lista de Pedidos.
        public async Task<List<Pedido>> Handle(GetPedidosQuery request, CancellationToken cancellationToken)
        {
            return await _pedidoRepository.GetAllAsync();
        }
    }
}
