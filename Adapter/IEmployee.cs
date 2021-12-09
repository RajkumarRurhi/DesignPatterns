using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public string Email { get; set; }

    }
}
