using EmployeeApp.Model;

namespace EmployeeApp.Service
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();

        public int SaveEmployee(Employee employee);
    }
}
