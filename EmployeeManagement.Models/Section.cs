using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Division Division { get; set; }
    }
}
