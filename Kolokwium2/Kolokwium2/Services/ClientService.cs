using Kolokwium2.DTO;
using Kolokwium2.Context;
using Kolokwium2.Models;

namespace Kolokwium2.Services;

public class ClientService : IClientService
{
    private readonly AppDbContext _context;

    public ClientService(AppDbContext context)
    {
        _context = context;
    }

    public ClientDto GetClient(int idKlient)
    {
        var client = _context.Clients.Find(idKlient);
        if (client == null) return null;
        
        return new ClientDto
        {
            IdClient = client.IdClient,
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
            Phone = client.Phone,
            Subscription = new List<SaleDto>()
            {
                GetSale(idKlient)
            }
        };
    }

    public SaleDto GetSale(int idKlient)
    {
        var client = _context.Sales.Find(idKlient);
        var client2 = _context.Subscriptions.Find(idKlient);
        var period = 0;
        if (client == null) return null;
        return new SaleDto
        {
            IdSubscription = client.IdSubscription,
            Subsctription = new SubscriptionDto()
            {
                Name = client2.Name,
                RenewalPeriod = client2.RenewalPeriod,
                TotalPaidAmount = client2.RenewalPeriod * client2.Price
            }
        };
    }
    
}