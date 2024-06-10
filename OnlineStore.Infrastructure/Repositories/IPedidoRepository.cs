using OnlineStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Repositories
{
    public interface IPedidoRepository
    {
        Task AddAsync(Pedido pedido);
        Task<List<Pedido>> GetAllAsync();
    }
}
