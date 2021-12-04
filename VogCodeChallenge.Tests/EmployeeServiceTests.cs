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
            // Assign
            EmployeeServices employeeService = new EmployeeServices();

            // Act
            var employees = employeeService.GetAll();

            // Assert
            Assert.NotNull(employees);
            Assert.Equal(3, employees.Count());
        }

        [Fact]
        public void ListAll_Returns_All_Employees()
        {
            // Assign
            EmployeeServices employeeService = new EmployeeServices();

            // Act
            var employees = employeeService.ListAll();

            // Assert
            Assert.NotNull(employees);
            Assert.Equal(3, employees.Count());
        }
       
    }
}
