using CoreIntro_0.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntro_0.Models.Entities
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public UserRole UserRole { get; set; }

        //Relational Properties
        public virtual EmployeeProfile EmployeeProfile { get; set; }
        public virtual IList<Order> Orders { get; set; }



    }
}
