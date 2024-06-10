using MediatR;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Application.Queries
{
    
    /// Representa una consulta para obtener todos los Pedidos.
    
    public class GetPedidosQuery : IRequest<List<Pedido>>
    {
    }
}
