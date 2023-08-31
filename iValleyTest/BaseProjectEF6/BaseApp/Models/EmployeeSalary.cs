using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaseApp.Models
{
    public class EmployeeSalary
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        public Decimal Amount { get; set; }
        public DateTime SalaryDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}