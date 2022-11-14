﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeeApp.Model
{
    public class EmployeeDbContext:DbContext
    {
       public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options) {

        }
        public DbSet<Employee> Employees { get; set;}
       
    }
}
