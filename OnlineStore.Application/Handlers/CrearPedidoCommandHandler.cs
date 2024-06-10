using MediatR;
using OnlineStore.Application.Commands;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.Application.Handlers
{
    public class CrearPedidoCommandHandler : IRequestHandler<CrearPedidoCommand, long>
    {
        private readonly IPedidoRepository _pedidoRepository;

        public CrearPedidoCommandHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<long> Handle(CrearPedidoCommand request, CancellationToken cancellationToken)
        {
            var pedido = new Pedido(request.Descripcion);
            await _pedidoRepository.AddAsync(pedido);
            return pedido.Id;
        }
    }
}
