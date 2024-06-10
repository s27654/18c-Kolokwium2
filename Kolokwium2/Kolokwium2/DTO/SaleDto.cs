using Kolokwium2.Models;

namespace Kolokwium2.DTO;

public class SaleDto
{
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    public SubscriptionDto Subsctription { get; set; }
}