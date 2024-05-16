using DesignPatternApp.Repository.Entities;

namespace DesignPatternApp.Business.Contracts
{
    public interface IEmployeeService
    {
        Employee? AddEmployee(Employee employee);
        Employee? GetEmployeeById(Guid id);
        List<Employee> GetAllEmployees();
        bool UpdateEmployee(Guid id, Employee employee);
        bool DeleteEmployee(Guid id);
    }
}