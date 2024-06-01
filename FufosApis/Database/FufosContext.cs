using Appointment.SDK.Backend.Database;
using Microsoft.EntityFrameworkCore;

namespace FufosApis.Database;

public class FufosContext(DbContextOptions options) : StoreContext(options)
{
}