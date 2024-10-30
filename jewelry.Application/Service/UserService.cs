
using jewerly.Domain.Contract.Service;
using jewerly.Domain.Dtos;

namespace jewerly.Application.Service;

public class userService : IUserService
{
    public ResultDto SignInUser(ApplicationUserLoginRequest request)
    {
        throw new NotImplementedException();
    }

    public ResultDto SignUpUser(ApplicationUserRegisterRequest request)
    {
        throw new NotImplementedException();
    }

    public ResultDto UpdateUser(ApplicationUserUpdateRequest request)
    {
        throw new NotImplementedException();
    }
}