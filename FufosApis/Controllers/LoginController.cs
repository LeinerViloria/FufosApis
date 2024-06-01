using Appointment.SDK.Backend.Controllers;
using FufosEntities.DTOS;
using Microsoft.AspNetCore.Mvc;
using FufosEntities.Entities;
using FufosEntities.Utilities;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using FufosApis.Utilities;

namespace FufosApis.Controllers
{
    [ApiController]
    public class LoginController(IServiceProvider serviceProvider) : StandardController(serviceProvider)
    {
        [HttpPost("/api/login")]
        public IActionResult Login([FromBody] UserDTO User)
        {
            using(var context = CreateContext())
            {

            }
            return Ok();
        }

        [HttpPost("/api/register")]
        public IActionResult Register([FromBody] UserDTO User)
        {
            var NewUser = new User()
            {
                Email = User.Email,
                Password = User.Password
            };

            var Errors = new List<ValidationResult>();

            var IsValid = DataAnnotationsValidator.Validate<User>(NewUser, ref Errors);

            if (!IsValid)
                throw new ArgumentNullException(JsonConvert.SerializeObject(Errors.Select(x => x.ErrorMessage)));

            NewUser.Password = Utils.HashTo256(NewUser.Password, _tokenConfiguration.Salt);

            using (var dbContext = CreateContext())
            {
                dbContext.Add(NewUser);
                dbContext.SaveChanges();
            }

            var Token = _jWTService.Generate(NewUser);
            return Ok(Token);
        }
    }
}
