
namespace jewelry.Domain.Contract.Repository;

public interface IUserRepository
{
    public bool IsUserExisteByUserName(string username);
}