using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" });

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 2, Name = "HR" });

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 3, Name = "GS" });

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 4, Name = "Payroll" });

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 5, Name = "IPPR" });

            modelBuilder.Entity<Employee>().HasData(
              new Employee
              {
                  Id = 1,
                  EmployeeId = 1,
                  BiometricId = 1,
                  FirstName = "Robinson",
                  LastName = "Chan",
                  SurName = "Jr",
                  Email = "robinson.chan@sonicsales.net",
                  Marital_Status = Marital_Status.Single,
                  Status = Status.Active,
                  DateOfBirth = new DateTime(1985, 4, 23),
                  Gender = Gender.Male,
                  PlaceOfBirth = "Davao City",
                  PermanentAddress = "Mandug Davao City",
                  CurrentAddress = "Mandug Davao City",
                  PhotoPath = "images/1.png"
              }); 

            modelBuilder.Entity<Employee>().HasData(
              new Employee
              {
                  Id = 2,
                  EmployeeId = 2,
                  BiometricId = 2,
                  FirstName = "Nancy",
                  LastName = "Taypin",
                  SurName = "",
                  Email = "hr@sonicsales.net",
                  Marital_Status = Marital_Status.Single,
                  Status = Status.Active,
                  DateOfBirth = new DateTime(1995, 5, 20),
                  Gender = Gender.Female,
                  PlaceOfBirth = "General Generoso",
                  PermanentAddress = "General Generoso",
                  CurrentAddress = "Agdao Davao City",
                  PhotoPath = "images/0.png"
              });

            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 3,
                EmployeeId = 3,
                BiometricId = 3,
                FirstName = "Joseph Vincent",
                LastName = "Limbaroc",
                SurName = "",
                Email = "IT@sonicsales.net",
                Marital_Status = Marital_Status.Single,
                Status = Status.Inactive,
                DateOfBirth = new DateTime(1995, 5, 20),
                Gender = Gender.Male,
                PlaceOfBirth = "Davao City",
                PermanentAddress = "Piapi Davao City",
                CurrentAddress = "Piapi Davao City",
                PhotoPath = "images/0.png"

            });

            modelBuilder.Entity<Employee>().HasData(
              new Employee
              {
                  Id = 4,
                  EmployeeId = 4,
                  BiometricId = 4,
                  FirstName = "Ofelia",
                  LastName = "Bernaldez",
                  SurName = "",
                  Email = "ofelia.bernaldez@sonicsales.net",
                  Marital_Status = Marital_Status.Married,
                  Status = Status.Active,
                  DateOfBirth = new DateTime(1992, 9, 20),
                  Gender = Gender.Female,
                  PlaceOfBirth = "Davao City",
                  PermanentAddress = "Piapi Davao City",
                  CurrentAddress = "Piapi Davao City",
                  PhotoPath = "images/0.png"
              });

            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 5,
                EmployeeId = 5,
                BiometricId = 5,
                FirstName = "Carol",
                LastName = "Genavia",
                SurName = "",
                Email = "carol.genavia@sonicsales.net",
                Marital_Status = Marital_Status.Married,
                Status = Status.Active,
                DateOfBirth = new DateTime(1982, 12, 20),
                Gender = Gender.Female,
                PlaceOfBirth = "Manila City",
                PermanentAddress = "Catalunan Grande Davao City",
                CurrentAddress = "Catalunan Grande Davao City",
                PhotoPath = "images/0.png"
            });

        }
    }
}
