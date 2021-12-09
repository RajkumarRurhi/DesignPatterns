using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class EmployeeLdapAdapter : IEmployee
    {
        private string firstName;
        private string lastName;
        private string employeeId;
        private string email;

        public EmployeeLdapAdapter(EmployeeFromLdap employeeFromLdap)
        {
            this.EmployeeId = employeeFromLdap.Cn;
            this.FirstName = employeeFromLdap.GivenName;
            this.LastName = employeeFromLdap.SurName;
            this.Email = employeeFromLdap.Mail;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return this.firstName + " - " + this.lastName + " - " + this.employeeId + " - " + this.Email;
        }
    }
}
