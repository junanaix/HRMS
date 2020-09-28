using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Job Superior { get; set; }
        public Division Division { get; set; }
        public Business_Unit Business_Unit { get; set; }
        public Section Section { get; set; }
        public Department Department { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime SeparatedDate { get; set; }
        public Status Status { get; set; }
        public decimal Salary { get; set; }
    }
}
