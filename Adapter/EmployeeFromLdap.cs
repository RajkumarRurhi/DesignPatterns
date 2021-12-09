using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class EmployeeFromLdap
    {
        private string cn;
        private string surName;
        private string givenName;
        private string mail;

        public EmployeeFromLdap(string cn, string surName, string givenName, string mail)
        {
            this.cn = cn;
            this.surName = surName;
            this.givenName = givenName;
            this.mail = mail;
        }

        public string Cn { get => cn; set => cn = value; }
        public string SurName { get => surName; set => surName = value; }
        public string GivenName { get => givenName; set => givenName = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
