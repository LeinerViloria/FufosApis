using Appointment.SDK.Backend.Configuration;
using FufosApis.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGlobalConfiguration<FufosContext>(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// app.MapPost("/login", (IServiceProvider provider, UserDTO Data) =>
// {
//     try
//     {
//         var Login = ActivatorUtilities.CreateInstance<LoginRepository>(provider);
//         var Result = new ActionResult<string>(){
//             Success = true,
//             Data = Login.Login(Data)
//         };
//         return Result;
//     }
//     catch (Exception e)
//     {
//         var Error = new ActionResult<string>(){
//             Error = "Invalid credentials"
//         };
//         return Error;
//     }
// }).WithName("LogIn")
// .WithOpenApi();

// app.MapPost("/register", (IServiceProvider provider, UserDTO Data) =>
// {
//    try
//    {
//         var Login = ActivatorUtilities.CreateInstance<LoginRepository>(provider);
//         var Result = new ActionResult<string>(){
//             Success = true,
//             Data = Login.Register(Data)
//         };
//         return Result;
//    }
//    catch (Exception e)
//    {
//         var Error = new ActionResult<string>(){
//             Error = string.IsNullOrEmpty($"{e.InnerException}") ?
//             e.Message : $"{e.InnerException}"
//         };
//         return Error;
//    }
// }).WithName("SignUp")
// .WithOpenApi();

app.Run();
