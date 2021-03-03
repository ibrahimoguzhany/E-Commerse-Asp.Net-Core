using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreIntro_0.Models.Entities;

namespace CoreIntro_0.VMClasses
{
    public class CategoryVM
    {
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}
