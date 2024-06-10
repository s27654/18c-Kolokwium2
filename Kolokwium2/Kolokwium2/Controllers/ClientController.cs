using Kolokwium2.DTO;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;
namespace Kolokwium2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    public ActionResult<ClientDto> GetClient(int id)
    {
        var client = _clientService.GetClient(id);
        if (client == null) return NotFound();
        return Ok(client);
    }
}