using CustomMiddleware;
using Microsoft.AspNetCore.WebUtilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

app.Use(async (context, next) =>
{
    // Custom logic before the next middleware
    await context.Response.WriteAsync("Hello from inline middleware\n");
    await next();
});

app.UseWhen( context => context.Request.Query.ContainsKey("username"),
             app => app.Use(async (context, next) =>
             {
                 // Custom logic before the next middleware
                 string username = context.Request.Query["username"].ToString();
                 await context.Response.WriteAsync("Hello from conditional middleware with username: " + username + "\n");
                 await next();
             })
);

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from terminal middleware\n");
});

app.Run();