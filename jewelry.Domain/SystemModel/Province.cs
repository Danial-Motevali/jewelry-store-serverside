
namespace jewerly.Domain.SystemModel;

public class Province
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int CityId { get; set; }

    public virtual City City { get; set; }
}