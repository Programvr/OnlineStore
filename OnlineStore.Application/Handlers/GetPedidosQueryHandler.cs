using MediatR;
using OnlineStore.Application.Queries;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.Application.Handlers
{
    public class GetPedidosQueryHandler : IRequestHandler<GetPedidosQuery, List<Pedido>>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public GetPedidosQueryHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<List<Pedido>> Handle(GetPedidosQuery request, CancellationToken cancellationToken)
        {
            return await _pedidoRepository.GetAllAsync();
        }
    }
}
