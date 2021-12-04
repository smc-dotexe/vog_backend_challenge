using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeServices
    {
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employees =
                from employee in EmployeeData.employeeList
                select employee;
                
            return employees;
        }

        public IList<Employee> ListAll()
        {
            IList<Employee> employeeList = new List<Employee>();
            foreach(Employee employee in EmployeeData.employeeList)
            {
                employeeList.Add(employee);
            }

            return employeeList;
        }
    }
}
