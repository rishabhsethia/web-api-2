using Entities.Models;
using GraphQL.Types;

namespace web_api_2.GraphQL.GraphQlTYpes
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            // Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
            Field<NonNullGraphType<GuidGraphType>>(nameof(Company.id));
            Field<NonNullGraphType<StringGraphType>>(nameof(Company.address));
            //.Description("Address property from the owner object.");
            Field<NonNullGraphType<StringGraphType>>(nameof(Company.country));
            //.Description("Country property from the owner object.");
            Field<NonNullGraphType<StringGraphType>>(nameof(Company.name));
            //.Description("Country property from the owner object.");
            //Field(x => x.Employees).Description("Country property from the owner object.");
        }
    }
}
