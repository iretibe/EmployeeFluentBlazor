﻿using EmployeeFluentBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeFluentBlazor.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
