using GraphQL.POC.Domain.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.POC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private readonly UserSchema userSchema;

        public GraphQLController(UserSchema userSchema)
        {
            this.userSchema = userSchema;
        }

        [HttpPost()]
        public IActionResult Post([FromBody] GraphQLQuery graphQLQuery)
        {
            var inputs = graphQLQuery.Variables.ToInputs();

            var schema = userSchema;

            var result = new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = graphQLQuery.Query;
                _.OperationName = graphQLQuery.OperationName;
                _.Inputs = inputs;
            }).Result;

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
