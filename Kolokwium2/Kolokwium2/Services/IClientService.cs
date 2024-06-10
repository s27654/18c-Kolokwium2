using Kolokwium2.DTO;
namespace Kolokwium2.Services;

public interface IClientService
{
    ClientDto GetClient(int idKlient);
    SaleDto GetSale(int idKlient);
}