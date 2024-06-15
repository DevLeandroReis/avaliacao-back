using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClienteApi.Application.Commands;
using ClienteApi.Application.Queries;
using ClienteApi.Application.Services;
using ClienteApi.Domain.Entities;

namespace ClienteApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Cliente>> Get()
        {
            return await _service.HandleAsync(new GetAllClientesQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _service.HandleAsync(new GetClienteByIdQuery(id));
            if (cliente == null)
            {
                return NotFound("Cliente not found.");
            }
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateClienteCommand command)
        {
            var result = await _service.HandleAsync(command);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(result.Error);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateClienteCommand command)
        {
            command.Id = id;
            var result = await _service.HandleAsync(command);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(result.Error);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.HandleAsync(new DeleteClienteCommand { Id = id });
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(result.Error);
        }
    }
}
