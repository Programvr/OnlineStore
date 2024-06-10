using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Events
{
    public class PedidoCreado
    {
        public Pedido Pedido { get; }

        public PedidoCreado(Pedido pedido)
        {
            Pedido = pedido;
        }
    }
}
