using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Application.Commands;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IPedidoRepository _pedidoRepository;

        public PedidosController(IMediator mediator, IPedidoRepository pedidoRepository)
        {
            _mediator = mediator;
            _pedidoRepository = pedidoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CrearPedidoCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pedidos = await _pedidoRepository.GetAllAsync();
            return Ok(pedidos);
        }
    }
}
