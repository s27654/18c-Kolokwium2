namespace Kolokwium2.DTO;

public class SaleSubscriptionDTO
{
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    public DateTime CreatedAt { get; set; }
    public SubscriptionDto SubscriptionDto { get; set; }
}