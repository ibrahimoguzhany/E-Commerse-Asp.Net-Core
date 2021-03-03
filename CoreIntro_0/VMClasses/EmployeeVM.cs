using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreIntro_0.Models.Entities;
using Microsoft.IdentityModel.Tokens;

namespace CoreIntro_0.VMClasses
{
    public class EmployeeVM
    {
        public List<Employee> Employees { get; set; }
        public Employee Employee { get; set; }
    }
}
