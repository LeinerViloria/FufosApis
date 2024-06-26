
using Appointment.SDK.Backend.Controllers;
using Appointment.SDK.Backend.Validations;
using FufosEntities.Entities;

namespace FufosApis.Controllers;

// Hereda de StandardController, clase que está en la libreria de Appointment.SDK.Backend
// En esa clase base está el crud
public class ProductController(IServiceProvider serviceProvider) : 
    StandardController<Product, BaseControllerValidator<Product>>(serviceProvider)
{
}