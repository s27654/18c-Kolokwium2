namespace Kolokwium2.DTO;

public class ClientDto
{
    public  int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public IEnumerable<SaleDto> Subscription { get; set; }
    
}