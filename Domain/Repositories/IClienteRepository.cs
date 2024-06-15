using System.Collections.Generic;
using System.Threading.Tasks;
using ClienteApi.Domain.Entities;

namespace ClienteApi.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente?> GetByIdAsync(int id);
        Task<bool> AddAsync(Cliente cliente);
        Task<bool> UpdateAsync(Cliente cliente);
        Task<bool> DeleteAsync(int id);
    }
}