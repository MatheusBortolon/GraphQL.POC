using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.POC
{
    public static class ConfigureSwagger
    {
        public static IApplicationBuilder AddSwagger(this IApplicationBuilder app) =>
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "teste"));

        public static IServiceCollection AddSwagger(this IServiceCollection services) =>
            services.AddSwaggerGen();
    }
}
