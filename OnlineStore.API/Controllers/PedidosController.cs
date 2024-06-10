using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Application.Commands;
using OnlineStore.Infrastructure.Repositories;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IMediator _mediator; // Maneja las solicitudes y respuestas de los comandos y consultas.
        private readonly IPedidoRepository _pedidoRepository; // Interactúa con la capa de persistencia para recuperar y almacenar Pedidos.

        public PedidosController(IMediator mediator, IPedidoRepository pedidoRepository)
        {
            _mediator = mediator;
            _pedidoRepository = pedidoRepository;
        }

        
        /// Crea un nuevo Pedido.
        
        /// Datos para crear el Pedido.</param>
        /// El identificador único del Pedido creado.
        [HttpPost]
        public async Task<IActionResult> Create(CrearPedidoCommand command)
        {
            var id = await _mediator.Send(command); // Envía el comando para crear un Pedido al manejador correspondiente.
            return Ok(id); // Devuelve el identificador único del Pedido creado.
        }

        
        /// Obtiene todos los Pedidos.
        
        /// <returns>Una lista de todos los Pedidos.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pedidos = await _pedidoRepository.GetAllAsync(); // Obtiene todos los Pedidos desde el repositorio.
            return Ok(pedidos); // Devuelve la lista de Pedidos.
        }
    }
}
