using Microsoft.AspNetCore.Builder;
using WebAPI.Middlewares;

namespace WebAPI.Extensions
{
    public static class AppExtension
    {
        public static void useErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
