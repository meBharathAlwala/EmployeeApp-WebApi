using EmployeeApp.Model;
using EmployeeApp.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{   
   
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        [HttpGet("EmployeeList")]
        public IEnumerable<Employee> GetEmployees()
        {
            return this._employeeRepository.GetEmployees();
        }

        [HttpPost("PostEmployee")]
        public int PostEmployee(Employee employee)
        {
            return this._employeeRepository.SaveEmployee(employee);
        }
    }
}
