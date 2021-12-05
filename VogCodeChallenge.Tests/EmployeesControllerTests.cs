using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.API.Classes.Entities;
using VogCodeChallenge.API.Controllers;
using VogCodeChallenge.API.Services;
using System.Linq;
using Xunit;

namespace VogCodeChallenge.Tests
{
    public class EmployeesControllerTests
    {

        [Fact]
        public async void HttpGet_Endpoint_Returns_AllEmployees()
        {
            // Arrange
            EmployeeServices _employeeServices = new EmployeeServices(new EmployeeTestData());
            EmployeesController _employeesController = new EmployeesController(_employeeServices);

            // Act
            var employeeGet = await _employeesController.AllEmployees();
            var employeesResult = employeeGet.Result as OkObjectResult;
            var employeeList = employeesResult.Value as List<Employee>;
        
            // Assert
            Assert.NotNull(employeeList);
            Assert.Equal(200, employeesResult.StatusCode);
            Assert.Equal(3, employeeList.Count);
        }

        [Fact]
        public async void HttpGet_Returns_StatusCode_200_With_No_Employees()
        {
            // Arrange
            EmployeeTestData emptyEmployeeData = new EmployeeTestData()
            {
                EmployeeList = new List<Employee>()
            };
            EmployeeServices employeeServices = new EmployeeServices(emptyEmployeeData);
            EmployeesController employeesController = new EmployeesController(employeeServices);

            // Act
            var employeeGet = await employeesController.AllEmployees();
            var employeesResult = employeeGet.Result as OkObjectResult;
            var employeeList = employeesResult.Value as List<Employee>;

            // Assert
            Assert.NotNull(employeeList);
            Assert.Equal(200, employeesResult.StatusCode);
            Assert.Empty(employeeList);
        }

        [Fact]
        public async void Department_Employees_Return_Employees_of_Matching_Department_and_StatusCode()
        {
            // Arrange
            EmployeeServices employeeServices = new EmployeeServices(new EmployeeTestData());
            EmployeesController employeesController = new EmployeesController(employeeServices);

            // Act
            var employeeGet = await employeesController.DepartmentEmployees(new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"));
            var employeesResult = employeeGet.Result as OkObjectResult;
            var employeeList = employeesResult.Value as IEnumerable<Employee>;

            // Assert
            Assert.NotNull(employeeList);
            Assert.Equal(200, employeesResult.StatusCode);
            Assert.Equal(2, employeeList.Count());
        }       
    }
}
