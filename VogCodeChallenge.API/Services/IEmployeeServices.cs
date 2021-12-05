using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeeServices
    {
        public IEnumerable<Employee> GetAll();
        public IList<Employee> ListAll();
        public IEnumerable<Employee> GetAllFromDepartment(Guid departmentId);

    }
}
