using Contracts.Modules.Emplyee;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }
        public IQueryable<Employee> GetAllEmployees(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(c => c.Name);
        }
    }
}
