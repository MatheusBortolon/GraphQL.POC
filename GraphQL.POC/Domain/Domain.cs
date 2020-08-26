using GraphQL.POC.Domain.Contract;
using GraphQL.POC.Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.POC.Domain
{
    public static class Domain
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services)
        {
            services.AddScoped<IUserUseCase, UserUseCase>();

            return services;
        }

    }
}
