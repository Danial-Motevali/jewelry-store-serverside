
using jewelry.Domain.Contract.Repository;
using jewerly.Domain.SystemModel;
using jewerly.Infectracture.Data;

namespace jewelry.Infectracture.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository
    (
        ApplicationDbContext context
    )
    {
        _context = context;
    }

    public ApplicationUser FindUserByFullName(string firstName, string lastName)
    {
        return _context.ApplicationUsers.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
    }

    public bool IsUserExisteByUserName(string firstName, string lastName)
    {
        ApplicationUser? user = _context.ApplicationUsers.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();

        if(user == null){
            return false;    
        }

        return true;
    }
}