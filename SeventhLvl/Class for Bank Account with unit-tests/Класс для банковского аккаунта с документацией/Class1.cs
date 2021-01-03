using System;

namespace ClassLibrary1
{
    /// <summary>
    /// Class for Bank Account
    /// </summary>

    public class BankAccount
    {
        public int Balance = 500;
        /// /// <summary>
        /// Method for withdrawing money from an account
        /// </summary>
        /// <param name="howMuch">How much money to take from the account.</param>

        public void TakeMoney(int howMuch)
        {

            if (this.Balance < howMuch)
            {
                Console.WriteLine("Exception:NotEnoughMoneyException");
            }
            else if (howMuch < 0)
            {
                Console.WriteLine("Exception:NegativeAmountException");
            }
            else
            {
                this.Balance -= howMuch;
            }
        }
    }
}
