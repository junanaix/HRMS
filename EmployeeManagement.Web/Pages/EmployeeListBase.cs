using Microsoft.AspNetCore.Components;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "John@batmanwisp.tech",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { Id = 1, Name = "Information Technology" },
                PhotoPath = "images/1.png"
            };

            Employee e2 = new Employee
            {
                Id = 1,
                FirstName = "John2",
                LastName = "Hastings",
                Email = "John2@batmanwisp.tech",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { Id = 1, Name = "Information Technology" },
                PhotoPath = "images/0.png"
            };

            Employee e3 = new Employee
            {
                Id = 1,
                FirstName = "John3",
                LastName = "Hastings",
                Email = "John3@batmanwisp.tech",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { Id = 1, Name = "Information Technology" },
                PhotoPath = "images/1.png"
            };

            Employee e4 = new Employee
            {
                Id = 1,
                FirstName = "John4",
                LastName = "Hastings",
                Email = "John4@batmanwisp.tech",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { Id = 1, Name = "Information Technology" },
                PhotoPath = "images/0.png"
            };

            Employee e5 = new Employee
            {
                Id = 1,
                FirstName = "John5",
                LastName = "Hastings",
                Email = "John5@batmanwisp.tech",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { Id = 1, Name = "Information Technology" },
                PhotoPath = "images/1.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4, e5 };
        }
    }
}
