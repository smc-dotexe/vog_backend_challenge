using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Classes.Entities
{
    public class Employee : BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MailingAddress { get; set; }

        public Guid DepartmentId { get; set; }

        // To prevent json looping through the same data since department has a list of employees field
        [JsonIgnore]
        public Department Department { get; set; }
    }
}
