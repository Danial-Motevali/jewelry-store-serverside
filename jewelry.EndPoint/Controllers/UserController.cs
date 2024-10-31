using jewerly.Domain.Contract.Service;
using jewerly.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace jewelry.EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IConfiguration _config;
    public UserController
    (
        IUserService userService,
        IConfiguration configuration
    )
    {
        _userService = userService;
        _config = configuration;
    }

    [HttpPost]
    [Route("Register")]
    public IActionResult RegisterUser([FromBody] ApplicationUserRegisterRequest userinfo){

        return Ok(_userService.SignUpUser(userinfo));
    }    

    [HttpPost]
    [Route("Login")]
    public IActionResult LoginUser([FromBody] ApplicationUserLoginRequest userInfo){
        
        return Ok(_userService.SignInUser(userInfo, _config));
    }

    [HttpPut]
    [Route("Update")]
    public IActionResult UpdateUser([FromBody] ApplicationUserUpdateRequest userRequest){

        return Ok(_userService.UpdateUser(userRequest));
    }
} 