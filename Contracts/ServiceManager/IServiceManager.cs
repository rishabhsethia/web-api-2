using Entities.Models;
using Service.Contracts;


namespace Contracts.Repository.ServiceManager
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; }
        IEmployeeService EmployeeService { get; }   
    }
}
