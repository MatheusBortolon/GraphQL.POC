using GraphQL.POC.Domain.Contract;
using GraphQL.POC.Domain.Entitys;
using GraphQL.POC.Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.POC.Domain
{
    public static class Domain
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services)
        {
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            
            services.AddScoped<IUserUseCase, UserUseCase>();

            services.AddScoped<UserGraphType>();
            services.AddScoped<UserQuery>();
            services.AddScoped<UserSchema>();
            services.AddScoped<GraphQLQuery>();
            
            return services;
        }

    }
}
