using GraphQL.POC.Domain;
using GraphQL.POC.Persistency;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQL.POC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .RegisterDomain()
                .RegisterPersistency()
                .AddSwagger()
                .AddGraphQL()
                .AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger()
               .AddSwagger()
               .UseRouting()
               .AddGraphQL()
               .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }

}
