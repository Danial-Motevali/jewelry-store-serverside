
using jewelry.Application.Utilites;
using jewelry.Domain.Contract.Repository;
using jewerly.Domain.Contract.Service;
using jewerly.Domain.Dtos;
using jewerly.Domain.SystemModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

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

    public ResultDto SignInUser(ApplicationUserLoginRequest request, IConfiguration config)
    {
        var result = new ResultDto();

        ApplicationUser user = _userRepo.FindUserByFullName(request.FirstName, request.LastName);

        if(user == null)
            return result.Faild("Cant Sign in the User");

        if(!BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
            return result.Faild("Cant sign in the User");

        TokenHelper tokenHelper = new (config);

        string jwtToken = tokenHelper.CreateToken(user);

        if(String.IsNullOrEmpty(jwtToken))
            return result.Faild("Cant sign in the User");

        return result.Success(jwtToken);
    }

    public ResultDto SignUpUser(ApplicationUserRegisterRequest request)
    {
        var result = new ResultDto();

        bool IsUserExiste = _userRepo.IsUserExisteByUserName(request.FirstName, request.LastName);
        if(IsUserExiste)
            return result.Faild("you All ready have a Account");

        ApplicationUser user = new ();

        if(request.Password != request.RePassword)
            return result.Faild("Passwords are not like each other");

        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.EmailAddress = request.Email;
        user.Password = BCrypt.Net.BCrypt.HashPassword(request.Password);
        user.PhoneNUmber = request.PhoneNumber;

        _userGeRepo.Insert(user);
        int saveResult = _userGeRepo.Save();

        if(saveResult == 0)
            return result.Faild("canst save the user");

        return result.Success(true);
    }

    public ResultDto UpdateUser(ApplicationUserUpdateRequest request)
    {
        throw new NotImplementedException();
    }
}