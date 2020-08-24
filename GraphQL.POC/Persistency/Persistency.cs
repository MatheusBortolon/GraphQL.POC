using GraphQL.POC.Persistency.Contracts;
using GraphQL.POC.Persistency.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.POC.Persistency
{
    public static class Persistency
    {
        public static IServiceCollection RegisterPersistency(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}
