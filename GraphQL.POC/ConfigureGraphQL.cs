using GraphQL.POC.Domain.Entitys;
using GraphQL.POC.Domain.UseCases;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.POC
{
    public static class ConfigureGraphQL
    {
        public static IApplicationBuilder AddGraphQL(this IApplicationBuilder app) =>
            app.UseGraphQL().UsePlayground();

        public static IServiceCollection AddGraphQL(this IServiceCollection services) =>
            services.AddGraphQL(s =>
                SchemaBuilder.New()
                    .AddServices(s)
                    .RegisterTypes()
                    .RegisterQuerys()
                    .Create(),
                new QueryExecutionOptions { ForceSerialExecution = true });
    }

    public static class RegistesGraphQLTypes
    {
        public static ISchemaBuilder RegisterTypes(this ISchemaBuilder schemaBuilder)
        {
            schemaBuilder.AddType<ObjectType<User>>();
            schemaBuilder.AddType<ObjectType<Address>>();
            schemaBuilder.AddType<ObjectType<KeyValueEntity>>();

            return schemaBuilder;
        }
    }

    public static class RegistesGraphQLQuerys
    {
        public static ISchemaBuilder RegisterQuerys(this ISchemaBuilder schemaBuilder)
        {
            schemaBuilder.AddQueryType<ObjectType<UserUseCase>>();

            return schemaBuilder;
        }
    }

}