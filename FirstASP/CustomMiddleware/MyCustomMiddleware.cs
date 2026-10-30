namespace CustomMiddleware
{
    public class MyCustomMiddleware: IMiddleware
    {

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Custom logic before the next middleware
            await context.Response.WriteAsync("Hello from MyCustomMiddleware\n");

            // Call the next middleware in the pipeline
            await next(context);

            // Custom logic after the next middleware
            await context.Response.WriteAsync("Goodbye from MyCustomMiddleware\n");
        }

    }

    public static class MyCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleware>();
        }
    }
}