using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Modules.Emplyee
{
    public interface IEmployeeRepository
    {
        IQueryable<Entities.Models.Employee> GetAllEmployees(bool trackChanges);
    }
}
