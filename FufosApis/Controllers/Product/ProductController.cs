
using Appointment.SDK.Backend.Controllers;
using Appointment.SDK.Backend.Validations;
using FufosEntities.Entities;

namespace FufosApis.Controllers;

public class ProductController(IServiceProvider serviceProvider) : 
    StandardController<Product, BaseControllerValidator<Product>>(serviceProvider)
{
}