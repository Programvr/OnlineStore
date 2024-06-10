using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Persistence;

namespace OnlineStore.Infrastructure.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly OnlineStoreDbContext _context;

        public PedidoRepository(OnlineStoreDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Pedido>> GetAllAsync()
        {
            return await _context.Pedidos.ToListAsync();
        }
    }
}
