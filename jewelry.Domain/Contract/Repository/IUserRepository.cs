
using jewerly.Domain.SystemModel;

namespace jewelry.Domain.Contract.Repository;

public interface IUserRepository
{
    public bool IsUserExisteByUserName(string username);
    public ApplicationUser FindUserByUserName(string username);
}