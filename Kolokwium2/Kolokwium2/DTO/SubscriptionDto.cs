namespace Kolokwium2.DTO;

public class SubscriptionDto
{
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPaidAmount { get; set; }
}