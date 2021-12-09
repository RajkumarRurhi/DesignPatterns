using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class EmployeeFromDb : IEmployee
    {
        private string firstName;
        private string lastName;
        private string employeeId;
        private string email;

        public EmployeeFromDb(string firstName, string lastName, string employeeId, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.email = email;
        }

        public string FirstName { get { return firstName; } set { firstName = value; }  }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string Email { get { return email; } set { email = value; } }

        public override string ToString()
        {
            return this.firstName + " - " + this.lastName + " - " + this.employeeId + " - " + this.Email;
        }
    }
}
