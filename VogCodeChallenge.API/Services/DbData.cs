using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Services
{
    public class DbData : Data
    {
        public DbData()
        {
            Software = new Department()
            {
                Id = new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"),
                Name = "Software Department",
                Address = "4307 130 ave SE",
                Employees = new List<Employee> { Employee1, Employee2, Employee3 }
            };

            Sales = new Department()
            {
                Id = new Guid("5b700373-f26e-4e5c-a52b-193152d978b8"),
                Name = "Sales Department",
                Address = "12 Centre Ave NE",
                Employees = new List<Employee> { Employee4 }
            };

            Employee1 = new Employee()
            {
                Id = new Guid("f34cca65-1705-4406-adb7-f4c7b0c23fd5"),
                FirstName = "Mary",
                LastName = "Lee",
                JobTitle = "Manager",
                MailingAddress = "2202 Harvest Cres NE",
                DepartmentId = Software.Id,
                Department = Software
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

            Employee4 = new Employee()
            {
                Id = new Guid("6099c7ec-c507-42e9-86bb-2de8716bb8ef"),
                FirstName = "Emily",
                LastName = "Xi",
                JobTitle = "Brand Consultant",
                MailingAddress = "8801 Hidden Valley Heights NW",
                DepartmentId = Sales.Id,
                Department = Sales
            };

            EmployeeList = new List<Employee>() { Employee1, Employee2, Employee3, Employee4 };
        }
    }
}
