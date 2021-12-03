using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Classes.Entities
{
    public class Department : BaseEntity<Guid>
    {
        public string Name;

        // If EF Core is installed, this Data Annotation will insure a unique address as required in step 2
        //[Index(nameof(Address), IsUnique = true]
        public string Address;
        public List<Employees> Employees { get; set; }
    }
}
