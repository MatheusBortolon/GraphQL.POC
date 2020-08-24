using GraphQL.POC.Persistency.Contracts;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.POC.Domain.Entitys
{
    public class UserGraphType : ObjectGraphType<User>
    {
        public UserGraphType()
        {
            Name = "User";
            Field(x => x.Name);
            //Field(x => x.Home);
            //Field(x => x.Work);
            //Field(x => x.Favorites);
        }
    }

    public class UserQuery : ObjectGraphType
    {
        public UserQuery(IUserRepository userRepository)
        {
            Field<ListGraphType<UserGraphType>>(nameof(User),
                arguments: new QueryArguments(new QueryArgument[] { 
                    new QueryArgument<StringGraphType>{Name=nameof(User.Name)},
                }),
                resolve: ctx => userRepository.GetUsersByPartialName(
                        ctx.GetArgument<string>(nameof(User.Name))
                )
            );
        }
    }

    public class UserSchema : Schema
    {
        public UserSchema(IServiceProvider serviceProvider, IDependencyResolver dependencyResolver)
            : base (dependencyResolver)
        {
            Query = serviceProvider.GetRequiredService<UserQuery>();
        }
    }
    public class GraphQLQuery
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
