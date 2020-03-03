using System;
using System.Collections.Generic;
using Payroll_Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Payroll_DAL
{
   public class EmployeeRepository
    {
        ContextClass EmployeeContextClass = new ContextClass();
        public void AddEmployee(Employee employee)
        {
            EmployeeContextClass.Employees.Add(employee);
            EmployeeContextClass.SaveChanges();
        }
        public IEnumerable<EmployeeDesigination> GetDesgination()
        {

            return EmployeeContextClass.Designation.ToList();
        }
    }
}
