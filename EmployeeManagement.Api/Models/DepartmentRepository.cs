﻿using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository

    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Department GetDepartment(int id)
        {
            return appDbContext.Departments
                .FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }
    }
}
