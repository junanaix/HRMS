using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BiometricID { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Marital_Status Marital_Status { get; set; }
        public Status Status { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string PhotoPath { get; set; }
    }
}
