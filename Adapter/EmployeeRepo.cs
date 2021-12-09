using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class EmployeeRepo
    {
        private List<IEmployee> employees = new List<IEmployee>();

        public List<IEmployee> GetEmployees()
        {
            EmployeeFromDb empDb1 = new EmployeeFromDb("Raj", "Kumar", "121", "Raj@test.com");
            employees.Add(empDb1);

            EmployeeFromDb empDb2 = new EmployeeFromDb("Raj2", "Kumar2", "122", "Raj2@test.com");
            employees.Add(empDb2);

            EmployeeLdapAdapter emp3 = new EmployeeLdapAdapter(new EmployeeFromLdap("rrurhi", "Kumar3", "Raj3", "Raj3@test.com"));
            employees.Add(emp3);

            return employees;
        }
    }
}
