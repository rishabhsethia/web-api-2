using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace web_api_2
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Company, CompanyDto>()
            //    .ForMember(c => c.FullAddress,
            //    opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Company, CompanyDto>()
                .ForCtorParam("FullAddress", 
                opt => opt.MapFrom(x => string.Join(' ', x.address, x.country)));
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
