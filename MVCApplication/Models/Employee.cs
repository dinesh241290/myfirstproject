using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class Employee
    {
        [Required]
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string Address { get; set; }
    }
}