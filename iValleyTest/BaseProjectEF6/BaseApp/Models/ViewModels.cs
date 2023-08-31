using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseApp.Models
{
    public class ViewModels
    {
        
            public IEnumerable<Employee> Employees { get; set; }
            public Employee Employee { get; set; }
            public EmployeeSalary EmployeeSalary { get; set; }


    }
}