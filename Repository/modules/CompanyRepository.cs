using Contracts;
using Contracts.Modules.Company;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IQueryable<Company> GetAllCompanies(bool trackChanges)
        {            
            return FindAll(trackChanges)
                .OrderBy(c => c.name);
        }
    }
}
