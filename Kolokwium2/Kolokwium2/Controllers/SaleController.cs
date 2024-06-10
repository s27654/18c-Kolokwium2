using Kolokwium2.DTO;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;
namespace Kolokwium2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SaleController : ControllerBase
{
    private readonly ISaleService _saleService;

    public SaleController(ISaleService saleService)
    {
        _saleService = saleService;
    }

    [HttpGet]
    public ActionResult<SaleSubscriptionDTO> SaleSubscription(int idClient, int idSubscription, int payment)
    {
        var sale = _saleService.SaleSubscription(idClient, idSubscription, payment);
        if (sale == null) return NotFound();
        return Ok(sale);
    }
}