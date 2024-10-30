
namespace jewerly.Domain.SystemModel;

public class ApplicationUser
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public virtual ICollection<Address>? Address { get; set; }
}