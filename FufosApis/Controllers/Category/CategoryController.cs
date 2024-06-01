
using Appointment.SDK.Backend.Controllers;
using Appointment.SDK.Backend.Validations;
using FufosEntities.Entities;

namespace FufosApis.Controllers;

public class CategoryController(IServiceProvider serviceProvider) : 
    StandardController<Category, BaseControllerValidator<Category>>(serviceProvider)
{
}