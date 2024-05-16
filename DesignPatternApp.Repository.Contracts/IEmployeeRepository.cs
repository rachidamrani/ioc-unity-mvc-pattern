using DesignPatternApp.Repository.Entities;

namespace DesignPatternApp.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        Employee? AddEmployee(Employee employee);
        Employee? GetEmployeeById(Guid id);
        List<Employee> GetAllEmployees();
        bool UpdateEmployee(Guid id, Employee employee);
        bool DeleteEmployee(Guid id);
    }
}