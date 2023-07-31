using Entities.Models;


namespace Contracts.Modules.Company
{
    public interface ICompanyRepository
    {
        IQueryable<Entities.Models.Company> GetAllCompanies(bool trackChanges);
    }
}
