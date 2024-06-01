
using Appointment.SDK.Backend.Controllers;
using Appointment.SDK.Backend.Validations;
using FufosEntities.Entities;

namespace FufosApis.Controllers;

public class UserController(IServiceProvider serviceProvider) : 
    StandardController<User, BaseControllerValidator<User>>(serviceProvider)
{
}