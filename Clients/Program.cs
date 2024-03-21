using Client.API.Middlewares;
using Client.Application;
using Client.Business.Interfaces;
using Client.Infrastracture.Repositories;
using System.Net.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<GetClientByIdUseCase>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<RequestResponseLoggingMiddleware>();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGet("/ichrak", () => "Hello ichraaak!");
app.MapPost("/put", (string name) =>"msg recieved" + name);

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello from 1st delegate.");
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello from 2st delegate.");
//});


/**************************************************************/
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello from 1st delegate.");
//    //await next();
//});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello from 2nd Middleware");
//});
/***********************************************************************/

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello from 1st delegate.");
//    await next();
//});

//app.Map("/api/client/1", a =>
//{
//    a.Run(async (context) =>
//    {
//        await context.Response.WriteAsync("New branch for auth");
//    });
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello from 2nd Middleware");
//});
app.Run();
