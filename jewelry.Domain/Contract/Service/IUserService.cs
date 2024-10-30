
using jewerly.Domain.Dtos;

namespace jewerly.Domain.Contract.Service;

public interface IUserService
{
    ResultDto SignInUser();
    ResultDto SignUpUser();
    ResultDto UpdateUser();
}