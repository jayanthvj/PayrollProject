using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class Account
    {
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}