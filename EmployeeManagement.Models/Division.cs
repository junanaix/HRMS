using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Business_Unit Business_Unit { get; set; }

    }
}
