using Kolokwium2.DTO;

namespace Kolokwium2.Services;

public interface ISaleService
{
    SaleSubscriptionDTO SaleSubscription(int IdClient, int IdSubscription, int Payment);
}