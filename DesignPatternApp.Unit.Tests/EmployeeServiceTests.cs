
using DesignPatternApp.Business;
using DesignPatternApp.Business.Contracts;
using DesignPatternApp.Repository.Contracts;
using DesignPatternApp.Repository.Entities;
using FluentAssertions;
using NSubstitute;

namespace DesignPatternApp.Unit.Tests
{
    public class EmployeeServiceTests
    {
        private readonly IEmployeeService _sut;
        private readonly IEmployeeRepository _employeeRepository = Substitute.For<IEmployeeRepository>();

        public EmployeeServiceTests()
        {
            _sut = new EmployeeService(_employeeRepository);
        }

        [Fact]
        public void GetAllEmployees_ShoulReturnEmptyList_WhenNoEmployeeExist()
        {
            // Arrange
            List<Employee> expected = new List<Employee>();

            // Configure the Repository GetAllEmployees method to return an empty list
            _employeeRepository.GetAllEmployees().Returns(Enumerable.Empty<Employee>().ToList());

            // Act
            List<Employee> result = _sut.GetAllEmployees();

            // Assert
            result.Should().BeEquivalentTo(expected);
        }


        [Fact]
        public void GetEmployeeById_ShouldReturnEmployeeWithGivenId_WhenEmployeeExist()
        {
            // Arrange
            Guid id = Guid.NewGuid();

            Employee expectedEmployee = new Employee(id, "John", "Doe", Salary: 3000);

            // Configure the Repository GetEmployeeById method to return the expected employee
            _employeeRepository.GetEmployeeById(id).Returns(expectedEmployee);

            // Act
            Employee? result = _sut.GetEmployeeById(id);

            result.Should().BeEquivalentTo(expectedEmployee);
        }
    }
}