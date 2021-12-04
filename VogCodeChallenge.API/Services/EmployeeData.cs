using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeData
    {
        readonly static Department software = new Department()
        {
            Id = new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"),
            Name = "Software Department",
            Address = "4307 130 ave SE",
            Employees = employeeList
        };

        readonly static Employee employee1 = new Employee()
        {
            Id = new Guid("f34cca65-1705-4406-adb7-f4c7b0c23fd5"),
            FirstName = "Mary",
            LastName = "Lee",
            JobTitle = "Manager",
            MailingAddress = "2202 Harvest Cres NE",
            DepartmentId = new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"),
            Department = software
        };

        readonly static Employee employee2 = new Employee()
        {
            Id = new Guid("cc912576-2b45-4f46-9016-613cd54651f2"),
            FirstName = "James",
            LastName = "Volkov",
            JobTitle = "Developer",
            MailingAddress = "80 Copperpond Pl SE",
            DepartmentId = new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"),
            Department = software
        };

        static Employee employee3 = new Employee()
        {
            Id = new Guid("3d9ef944-2a11-497f-9d82-f6a7d0b46df5"),
            FirstName = "Shahid",
            LastName = "Akhtar",
            JobTitle = "QA Tester",
            MailingAddress = "471 Edgemont Circle NW",
            DepartmentId = new Guid("51b3b7be-d70e-4c4b-916d-1443e13440c0"),
            Department = software
        };

        public static List<Employee> employeeList = new List<Employee>() { employee1, employee2, employee3 };

    }
}
