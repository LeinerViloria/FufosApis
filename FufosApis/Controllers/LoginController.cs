using Appointment.SDK.Backend.Controllers;
using FufosEntities.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace FufosApis.Controllers
{
    [ApiController]
    public class LoginController(IServiceProvider serviceProvider) : StandardController(serviceProvider)
    {
        [HttpPost("/api/login")]
        public IActionResult Login([FromBody] UserDTO User)
        {
            return Ok();
        }

        [HttpPost("/api/register")]
        public IActionResult Register([FromBody] UserDTO User)
        {
            return Ok();
        }
    }
}
