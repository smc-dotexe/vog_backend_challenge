using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Classes.Entities
{
    public class Employees : BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MailingAddress { get; set; }

        // Relationship with Department Entity
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
