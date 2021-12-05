using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Services
{
    public abstract class Data
    {
        public Department Software;
        public Department Sales;
        public Employee Employee1;
        public Employee Employee2;
        public Employee Employee3;
        public Employee Employee4;
        public List<Employee> EmployeeList;
    }
}
