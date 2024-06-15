using Microsoft.EntityFrameworkCore;
using ClienteApi.Domain.Entities;

namespace ClienteApi.Infrastructure.Data
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais de mapeamento
        }
    }
}
