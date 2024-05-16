using DesignPatternApp.Infrastructure;
using DesignPatternApp.Repository.Contracts;
using DesignPatternApp.Repository.Entities;

namespace DesignPatternApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        LocalStorage _localStorage;

        public EmployeeRepository()
        {
            _localStorage = LocalStorage.Instance;
        }

        public Employee? AddEmployee(Employee employee)
        {
            _localStorage.employees.Add(employee);
            Employee? addedEmployee = _localStorage.employees.Find(e => e.Id == employee.Id);

            return addedEmployee is not null ? addedEmployee : null;
        }

        public Employee? GetEmployeeById(Guid id)
        {
            return _localStorage.employees.Find(e => e.Id == id);
        }
        public List<Employee> GetAllEmployees() => _localStorage.employees;

        public bool UpdateEmployee(Guid id, Employee employee)
        {
            Employee? employeeUpdateTarget = _localStorage.employees.Find(e => e.Id == id);
            int employeeUpdateTargetIndex = _localStorage.employees.FindIndex(e => e.Id == id);

            if (employeeUpdateTarget is null) return false;

            employeeUpdateTarget = new Employee(employee.Id, employee.FirstName, employee.LastName, employee.Salary);

            _localStorage.employees.RemoveAt(employeeUpdateTargetIndex);
            _localStorage.employees.Add(employeeUpdateTarget);

            return true;
        }

        public bool DeleteEmployee(Guid id)
        {
            Employee? employee = _localStorage.employees.Find(e => e.Id == id);

            if (employee is not null)
            {
                _localStorage.employees.Remove(employee);
                return true;
            }

            return false;

        }

    }
}