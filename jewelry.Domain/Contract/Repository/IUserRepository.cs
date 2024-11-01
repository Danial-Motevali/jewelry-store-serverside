
using jewerly.Domain.SystemModel;

namespace jewelry.Domain.Contract.Repository;

public interface IUserRepository
{
    public bool IsUserExisteByUserName(string firstName, string lastName);
    public ApplicationUser FindUserByFullName(string firstName, string lastName);
}