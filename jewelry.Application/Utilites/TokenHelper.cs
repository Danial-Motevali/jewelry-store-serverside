
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using jewerly.Domain.SystemModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace jewelry.Application.Utilites;

public class TokenHelper
{
    private readonly IConfiguration _config;
    public TokenHelper
    (
        IConfiguration configuration
    )
    {
        _config = configuration;
    }

    public string CreateToken(ApplicationUser user)
    {
        List<Claim> claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSetting:Token").Value!));

        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: cred
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}

