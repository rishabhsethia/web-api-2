using Contracts.Repository.ServiceManager;
using GraphQL.Types;

namespace web_api_2.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IServiceManager service )
        {
            Field<ListGraphType<GraphQlTYpes.CompanyType>>(
               "Company",
               resolve: context => service.CompanyService.GetAllCompanies(false)
           );
        }
    }
}
