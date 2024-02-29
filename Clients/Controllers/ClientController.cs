using Client.Application;
using Client.Business.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Client.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly GetClientByIdUseCase _getClientByIdUseCase;
        public ClientController(GetClientByIdUseCase getClientByIdUseCase)
        {
            _getClientByIdUseCase = getClientByIdUseCase;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientEntity>> Get(int id)
        {
            var client = await _getClientByIdUseCase.ExecuteAsync(id);
            if (client == null)
                return NotFound();

            return Ok(client);
        }
    }
}
