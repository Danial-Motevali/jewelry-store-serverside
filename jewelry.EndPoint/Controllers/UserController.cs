using Microsoft.AspNetCore.Mvc;

namespace jewelry.EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(){

        return Ok();
    }    
} 