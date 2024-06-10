using MediatR;

namespace OnlineStore.Application.Commands
{
    public class CrearPedidoCommand : IRequest<long>
    {
        public string Descripcion { get; set; }

        public CrearPedidoCommand(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
