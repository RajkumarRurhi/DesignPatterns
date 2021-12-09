using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    internal class Employee
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Name} - {ContactNumber} - {Address}";
        }

        public EmployeeMomento Save()
        {
            return new EmployeeMomento() { Address = Address, Name = Name, ContactNumber = ContactNumber };
        }

        public void Revert(EmployeeMomento employeeMomento)
        {
            this.Name = employeeMomento.Name;
            this.ContactNumber = employeeMomento.ContactNumber;
            this.Address = employeeMomento.Address;
        }
    }
}
