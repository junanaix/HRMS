using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var result = await appDbContext.Employees
                 .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;

        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.Id == id);
        }



        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.Email == email);
        } 

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = appDbContext.Employees;
            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }

            if (gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }

            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employees
                 .FirstOrDefaultAsync(e => e.Id == employee.Id);
            if (result != null)
            {
                result.EmployeeId = employee.EmployeeId;
                result.BiometricID = employee.BiometricID;
                result.Marital_Status = employee.Marital_Status;
                result.Status = employee.Status;
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.SurName = employee.SurName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.PlaceOfBirth = employee.PlaceOfBirth;
                result.Marital_Status = employee.Marital_Status;
                result.PermanentAddress = employee.PermanentAddress;
                result.CurrentAddress = employee.CurrentAddress;
                result.Gender = employee.Gender;
                result.PhotoPath = employee.PhotoPath;
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}
