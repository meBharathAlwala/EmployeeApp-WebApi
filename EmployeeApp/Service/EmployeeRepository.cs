using EmployeeApp.Model;
using System.Diagnostics;

namespace EmployeeApp.Service
{

    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        { 
            this._employeeDbContext = employeeDbContext;
        }    
        public List<Employee> GetEmployees()
        {
            return this._employeeDbContext.Employees.ToList();
        }

        public int SaveEmployee(Employee employee)
        {
            this._employeeDbContext.Employees.Add(employee);
           return this._employeeDbContext.SaveChanges();
        }
    }
}
