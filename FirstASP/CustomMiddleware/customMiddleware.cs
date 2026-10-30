using System;

namespace FirstASP.CustomMiddleware
{
    public class customMiddleware
{
    private readonly RequestDelegate _next;
    public customMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Custom logic before the next middleware
        await context.Response.WriteAsync("Hello from customMiddleware\n");

        // Call the next middleware in the pipeline
        await _next(context);

        // Custom logic after the next middleware
        await context.Response.WriteAsync("Goodbye from customMiddleware\n");
    }

}

public static class customMiddlewareExtensions
{
    public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<customMiddleware>();
    }
}
}



