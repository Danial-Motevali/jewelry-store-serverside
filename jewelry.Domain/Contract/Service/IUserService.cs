
using jewerly.Domain.Dtos;
using Microsoft.Extensions.Configuration;

namespace jewerly.Domain.Contract.Service;

public interface IUserService
{
    ResultDto SignInUser(ApplicationUserLoginRequest request, IConfiguration configuration);
    ResultDto SignUpUser(ApplicationUserRegisterRequest request);
    ResultDto UpdateUser(ApplicationUserUpdateRequest request);
}