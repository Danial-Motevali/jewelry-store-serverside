
namespace jewerly.Domain.SystemModel;

public class Address
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AddressDetail { get; set; }
    public int HouseNumber { get; set; }

    public int CityId { get; set; }
    public int ProvinceId { get; set; }
    public int UserId { get; set; }


    public virtual Province Province { get; set; }
    public virtual City City { get; set; }
    public virtual ApplicationUser User { get; set; }
}