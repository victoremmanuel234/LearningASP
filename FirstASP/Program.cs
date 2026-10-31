var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Map("files/{filename :minlength(10)}.{extension}",async context =>
{
    var filename = context.Request.RouteValues["filename"]?.ToString();
    var extension = context.Request.RouteValues["extension"]?.ToString();
    await context.Response.WriteAsync($"the request sent at filename: {filename}, extension: {extension}");
});

app.MapFallback(async context =>
{
    await context.Response.WriteAsync("this is the fallback Routing");
});
app.Run();