using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.API.Classes.Entities;
using VogCodeChallenge.API.Services;
using Xunit;

namespace VogCodeChallenge.Tests
{
    public class EmployeeServiceTests
    {
        [Fact]
        public void GetAll_Returns_All_Employees()
        {
            // Arrange
            EmployeeServices employeeService = new EmployeeServices(new EmployeeTestData());

            // Act
            var employees = employeeService.GetAll();

            // Assert
            Assert.NotNull(employees);
            Assert.Equal(3, employees.Count());
        }

        [Fact]
        public void ListAll_Returns_All_Employees()
        {
            // Arrange
            EmployeeServices employeeService = new EmployeeServices(new EmployeeTestData());

            // Act
            var employees = employeeService.ListAll();

            // Assert
            Assert.NotNull(employees);
            Assert.Equal(3, employees.Count());
        }

        [Fact]
        public void Gets_Employees_From_Specific_Department()
        {
            // Arrange
            EmployeeServices employeeService = new EmployeeServices(new EmployeeTestData());

            // Act
            var salesEmployees = employeeService.GetAllFromDepartment(new Guid("5b700373-f26e-4e5c-a52b-193152d978b8"));
            var softwareEmployees = employeeService.GetAllFromDepartment(new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"));

            // Assert
            Assert.NotNull(salesEmployees);
            Assert.Single(salesEmployees);
            Assert.Equal(2, softwareEmployees.Count());
        }

        [Fact]
        public void GetAllFromDepartment_Returns_Empty_If_None_Matching()
        {
            EmployeeServices employeeService = new EmployeeServices(new EmployeeTestData());

            var noEmployees = employeeService.GetAllFromDepartment(new Guid("62b663c4-6473-42fb-94b2-6d5c6c5c5aa2"));

            Assert.NotNull(noEmployees);
            Assert.Empty(noEmployees);
        }
       
    }
}
