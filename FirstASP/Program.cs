using FirstASP.CustomMiddleware;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    WebRootPath = "wwwroot"
});
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("custom", typeof(FirstASP.customConstraints.CustomConstraints));
});

builder.Services.AddControllers();

var app = builder.Build();


app.UseStaticFiles();
app.MapControllers();



app.Run();