using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        readonly Data _employeeData;

        public EmployeeServices(Data employeeData)
        {
            _employeeData = employeeData;
        }
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employees =
                from employee in _employeeData.EmployeeList
                select employee;
                
            return employees;
        }

        public IList<Employee> ListAll()
        {
            IList<Employee> employeeList = new List<Employee>();
            foreach(Employee employee in _employeeData.EmployeeList)
            {
                employeeList.Add(employee);
            }

            return employeeList;
        }

        public IEnumerable<Employee> GetAllFromDepartment(Guid departmentId)
        {
            IEnumerable<Employee> employees =
             _employeeData.EmployeeList.Where(employee => employee.DepartmentId == departmentId);

            return employees;
        }
    }
}
