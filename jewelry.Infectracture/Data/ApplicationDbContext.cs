
using jewerly.Domain.SystemModel;
using Microsoft.EntityFrameworkCore;

namespace jewerly.Infectracture.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }
}