using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.API.Classes.Entities;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.Tests
{
    public class EmployeeTestData : Data
    {

        public EmployeeTestData()
        {
            Software = new Department()
            {
                Id = new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"),
                Name = "Software Department",
                Address = "4307 130 ave SE",
                Employees = new List<Employee>() { Employee2, Employee3 }
            };

            Sales = new Department()
            {
                Id = new Guid("5b700373-f26e-4e5c-a52b-193152d978b8"),
                Name = "Sales Department",
                Address = "12 Centre Ave NE",
                Employees = new List<Employee>() { Employee1 }
            };

            Employee1 = new Employee()
            {
                Id = new Guid("f34cca65-1705-4406-adb7-f4c7b0c23fd5"),
                FirstName = "Mary",
                LastName = "Lee",
                JobTitle = "Manager",
                MailingAddress = "2202 Harvest Cres NE",
                DepartmentId = Sales.Id,
                Department = Sales
            };

            Employee2 = new Employee()
            {
                Id = new Guid("cc912576-2b45-4f46-9016-613cd54651f2"),
                FirstName = "James",
                LastName = "Volkov",
                JobTitle = "Developer",
                MailingAddress = "80 Copperpond Pl SE",
                DepartmentId = Software.Id,
                Department = Software
            };

            Employee3 = new Employee()
            {
                Id = new Guid("3d9ef944-2a11-497f-9d82-f6a7d0b46df5"),
                FirstName = "Shahid",
                LastName = "Akhtar",
                JobTitle = "QA Tester",
                MailingAddress = "471 Edgemont Circle NW",
                DepartmentId = Software.Id,
                Department = Software
            };

            EmployeeList = new List<Employee>() { Employee1, Employee2, Employee3 };
        }
    }
}
