
namespace jewerly.SystemModel;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Province> Province { get; set; }
}