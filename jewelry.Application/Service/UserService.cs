
using jewelry.Domain.Contract.Repository;
using jewerly.Domain.Contract.Service;
using jewerly.Domain.Dtos;
using jewerly.Domain.SystemModel;

namespace jewerly.Application.Service;

public class userService : IUserService
{
    private readonly IGenericRepository<ApplicationUser> _userGeRepo;
    private readonly IUserRepository _userRepo;
    public userService
    (
        IGenericRepository<ApplicationUser> userGeRepo,
        IUserRepository userRepo
    )
    {
        _userGeRepo = userGeRepo;
        _userRepo = userRepo;
    }

    public ResultDto SignInUser(ApplicationUserLoginRequest request)
    {
        var result = new ResultDto();

        bool IsUserExiste = _userRepo.IsUserExisteByUserName(request.Name);
        if(IsUserExiste)
            return result.Faild("you All ready have a Account");

        
        return null;
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