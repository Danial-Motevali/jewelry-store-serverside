
using jewerly.Domain.Dtos;

namespace jewerly.Domain.Contract.Service;

public interface IUserService
{
    ResultDto SignInUser(ApplicationUserLoginRequest request);
    ResultDto SignUpUser(ApplicationUserRegisterRequest request);
    ResultDto UpdateUser(ApplicationUserUpdateRequest request);
}