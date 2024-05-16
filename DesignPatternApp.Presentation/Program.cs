using Unity;
using static System.Console;
using DesignPatternApp.Business;
using DesignPatternApp.Business.Contracts;
using DesignPatternApp.Repository.Entities;
using DesignPatternApp.Controllers;
using DesignPatternApp.Repository.Contracts;
using DesignPatternApp.Repository;

// Create Unity container
IUnityContainer unityContainer = new UnityContainer();

// Register Unity container
unityContainer.RegisterType<IEmployeeService, EmployeeService>();
unityContainer.RegisterType<IEmployeeRepository, EmployeeRepository>();


// Instanciate the employee controller
EmployeeController employeeController = unityContainer.Resolve<EmployeeController>();

// TODO : Add an employee
Employee employee = new Employee(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d5"), "John", "Doe", 4000);
Employee employee2 = new Employee(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d6"), "Jane", "Dane", 5000);

employeeController.AddEmployee(employee);
employeeController.AddEmployee(employee2);

// TODO : Get all employees
// List<Employee> employees = employeeController.GetAllEmployees();

// foreach (Employee emp in employees)
// {
//     WriteLine($"{emp.Id} - {emp.FirstName} {emp.LastName} | Salary : {emp.Salary}");
// }

// TODO : Get employee by id
WriteLine(employeeController.GetEmployeeById(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d6"))?.ToString());


// TODO : Update employee
Employee update = new Employee(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d6"), "XXXXX", "XXXXX", 39000);
employeeController.UpdateEmployee(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d6"), update);

// TODO : Delete employee
// employeeController.DeleteEmployee(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d6"));


// Has been deleted
WriteLine(employeeController.GetEmployeeById(Guid.Parse("4588cd8a-34d8-462f-a75a-98ffa62ed5d6"))?.ToString());