
namespace jewerly.Domain.Dtos;

public class ApplicationUserRegisterRequest
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string RePassword { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}

public class ApplicationUserLoginRequest
{
    public string Name { get; set; }
    public string Password { get; set; }
}

public class ApplicationUserUpdateRequest
{
}