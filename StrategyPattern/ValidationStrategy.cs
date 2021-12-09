using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal abstract class ValidationStrategy
    {
        public abstract bool isValid(CreditCard creditCard);

		protected bool passesLuhn(String ccNumber)
		{
			int sum = 0;
			bool alternate = false;
			for (int i = ccNumber.Length - 1; i >= 0; i--)
			{
				int n = Int32.Parse(ccNumber.Substring(i, 1));
				if (alternate)
				{
					n *= 2;
					if (n > 9)
					{
						n = (n % 10) + 1;
					}
				}
				sum += n;
				alternate = !alternate;
			}
			return (sum % 10 == 0);
		}
	}
}
