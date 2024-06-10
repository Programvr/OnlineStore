using MediatR;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Application.Queries
{
    public class GetPedidosQuery : IRequest<List<Pedido>>
    {
    }
}
