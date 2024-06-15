using System.Collections.Generic;
using System.Threading.Tasks;
using ClienteApi.Domain.Entities;
using ClienteApi.Domain.Repositories;
using ClienteApi.Application.Commands;
using ClienteApi.Application.Queries;

namespace ClienteApi.Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Cliente>> HandleAsync(GetAllClientesQuery _)
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Cliente?> HandleAsync(GetClienteByIdQuery query)
        {
            return await _repository.GetByIdAsync(query.Id);
        }

        public async Task<Result> HandleAsync(CreateClienteCommand command)
        {
            var cliente = new Cliente
            {
                Nome = command.Nome,
                Porte = command.Porte
            };

            var created = await _repository.AddAsync(cliente);
            return created ? Result.Success() : Result.Failure("Cliente could not be created.");
        }

        public async Task<Result> HandleAsync(UpdateClienteCommand command)
        {
            var cliente = await _repository.GetByIdAsync(command.Id);
            if (cliente == null)
            {
                return Result.Failure("Cliente not found.");
            }

            cliente.Nome = command.Nome;
            cliente.Porte = command.Porte;
            var updated = await _repository.UpdateAsync(cliente);

            return updated ? Result.Success() : Result.Failure("Cliente could not be updated.");
        }

        public async Task<Result> HandleAsync(DeleteClienteCommand command)
        {
            var deleted = await _repository.DeleteAsync(command.Id);
            return deleted ? Result.Success() : Result.Failure("Cliente could not be deleted.");
        }
    }
}