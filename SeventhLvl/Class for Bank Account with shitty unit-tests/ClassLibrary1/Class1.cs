using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Class for Bank Account
    /// </summary>

    public static class BankAccount
    {
        public static  int Balance = 500;
        /// /// <summary>
        /// Method for withdrawing money from an account
        /// </summary>
        /// <param name="howMuch">How much money to take from the account.</param>

        public static  bool TakeMoney(int howMuch)
        {
            bool result = true;
            if (Balance < howMuch)
            {
                Console.WriteLine("Exception:NotEnoughMoneyException");
                result = false;
            }
            else if (howMuch < 0)
            {
                Console.WriteLine("Exception:NegativeAmountException");
                result = false;
            }
            else
            {
                Balance -= howMuch;
                result = true;
            }
            return result;
        }
    }
}
