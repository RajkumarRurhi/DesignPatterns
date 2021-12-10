using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class AccountNumberCheck
    {
        int accountNumber = 987654321;

        public bool IsAccountActive(int accNumber)
        {
            if(accountNumber == accNumber)
                return true;
            else
                return false;
        }
    }
}
