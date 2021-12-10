using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class SecurityCodeCheck
    {
        int securityCode = 1234;

        public bool IsCodeCorrect(int secCode)
        {
            if (securityCode == secCode)
                return true;
            else
                return false;
        }
    }
}
