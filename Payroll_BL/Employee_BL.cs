using System;
using Payroll_DAL;
using Payroll_Entity;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Payroll_BL
{
   public class Employee_BL
    {
        EmployeeRepository repository = new EmployeeRepository();
        public void AddEmployeedata(Employee employee)
        {
            repository.AddEmployee(employee);
        }
        public IEnumerable<EmployeeDesigination> GetDesgination()
        {
            return repository.GetDesgination();
        }
    }
}