
namespace jewerly.Domain.SystemModel;

public class ApplicationUser
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string? EmailAddress { get; set; }
    public string PhoneNUmber { get; set; }

    public virtual ICollection<Address>? Address { get; set; }
}