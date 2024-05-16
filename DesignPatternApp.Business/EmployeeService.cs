using DesignPatternApp.Business.Contracts;
using DesignPatternApp.Repository.Contracts;
using DesignPatternApp.Repository.Entities;

namespace DesignPatternApp.Business
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository EmployeeRepository { get; }

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        public Employee? AddEmployee(Employee employee)
        {
            return EmployeeRepository.AddEmployee(employee);
        }

        public Employee? GetEmployeeById(Guid id)
        {
            return EmployeeRepository.GetEmployeeById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeeRepository.GetAllEmployees();
        }

        public bool DeleteEmployee(Guid id) => EmployeeRepository.DeleteEmployee(id);

        public bool UpdateEmployee(Guid id, Employee employee) => EmployeeRepository.UpdateEmployee(id, employee);
    }
}