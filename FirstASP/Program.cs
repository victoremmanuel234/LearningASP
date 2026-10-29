using Microsoft.AspNetCore.WebUtilities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    string request = context.Request.Path;
    string query = context.Request.QueryString.ToString();
    StreamReader reader = new StreamReader(context.Request.Body);
    string body = await reader.ReadToEndAsync();
    
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("path: " + request + ", query: " + query);

});

app.Run();