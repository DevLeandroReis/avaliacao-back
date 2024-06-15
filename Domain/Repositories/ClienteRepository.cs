using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClienteApi.Domain.Entities;
using ClienteApi.Domain.Repositories;
using ClienteApi.Infrastructure.Data;

namespace ClienteApi.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteDbContext _context;

        public ClienteRepository(ClienteDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente?> GetByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<bool> AddAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}