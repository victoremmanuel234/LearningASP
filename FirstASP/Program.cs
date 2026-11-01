var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("custom", typeof(FirstASP.customConstraints.CustomConstraints));
});
var app = builder.Build();


app.Map("files/{filename :custom}.{extension}",async context =>
{
    var filename = context.Request.RouteValues["filename"]?.ToString();
    var extension = context.Request.RouteValues["extension"]?.ToString();
    await context.Response.WriteAsync($"the request sent at filename: {filename}, extension: {extension}");
});

app.Map("works/worker/{date: custom}", async context =>
{
    var date = context.Request.RouteValues["date"]?.ToString();
    await context.Response.WriteAsync($"the request sent at date: {date}");
});

app.MapFallback(async context =>
{
    await context.Response.WriteAsync("this is the fallback Routing");
});


app.Run();