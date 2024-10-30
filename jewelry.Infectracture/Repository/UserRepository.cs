
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

    public bool IsUserExisteByUserName(string username)
    {
        ApplicationUser? user = _context.ApplicationUsers.Where(x => x.UserName == username).FirstOrDefault();

        if(user == null){
            return true;    
        }

        return false;
    }
}