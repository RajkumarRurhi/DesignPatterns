using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    internal class EmployeeMomentoCareTaker
    {
        private Stack<EmployeeMomento> employeeMomentos = new Stack<EmployeeMomento>();

        public void Save(Employee employee)
        {
            employeeMomentos.Push(employee.Save());
        }

        public void Revert(Employee employee)
        {
            employee.Revert(employeeMomentos.Pop());
        }
    }
}
