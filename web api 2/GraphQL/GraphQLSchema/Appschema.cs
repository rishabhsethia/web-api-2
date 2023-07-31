using GraphQL.Types;
using web_api_2.GraphQL.GraphQLQueries;

namespace web_api_2.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}
