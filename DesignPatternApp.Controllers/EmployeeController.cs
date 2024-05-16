using DesignPatternApp.Business.Contracts;
using DesignPatternApp.Repository.Entities;

namespace DesignPatternApp.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public Employee? AddEmployee(Employee employee)
        {
            return _employeeService.AddEmployee(employee);
        }

        public List<Employee> GetAllEmployees() => _employeeService.GetAllEmployees();

        public Employee? GetEmployeeById(Guid id) => _employeeService.GetEmployeeById(id);

        public bool UpdateEmployee(Guid id, Employee employee) => _employeeService.UpdateEmployee(id, employee);
        public bool DeleteEmployee(Guid id) => _employeeService.DeleteEmployee(id);
    }
}