using Contracts.Modules.@base;
using Contracts.Repository.ServiceManager;
using Microsoft.AspNetCore.Mvc;
using Service;
using Shared.DataTransferObjects;

namespace CompanyEmployees.Presentation.Controllers
{


    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly ILoggerManager _logger;
        public CompaniesController(IServiceManager service, ILoggerManager logger)
        {
            _logger = logger;
            _service = service;
        }
        [HttpGet("Companies")]
        public IActionResult GetCompanies()
        {
            try
            {
                var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
                _logger.LogInfo("I Am comming home, tell the world I am coming home");
                return Ok(companies);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("SomeEmployee")]
        public IActionResult GetEmployeesForACompany(string company_id)
        {
            try
            {
                var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
                var employees = _service.EmployeeService.GetAllEmployees(trackChanges:false);
                employees = employees.AsEnumerable<EmployeeDto>()
                    .Where(eDto => eDto.CompanyId == new Guid(company_id)); // c9d4c053-49b6-410c-bc78-2d54a9991870 
                _logger.LogInfo("I Am comming home");
                return Ok(employees);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }

}
