using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaseApp.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("myconnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<BaseApp.Models.EmployeeSalary> EmployeeSalaries { get; set; }
    }
}