using CustomMiddleware;
using Microsoft.AspNetCore.WebUtilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from middleware 1\n");
    await next(context);
});

app.UseMyCustomMiddleware();

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from Called Middleware from custom middleware\n");
});

app.Run();