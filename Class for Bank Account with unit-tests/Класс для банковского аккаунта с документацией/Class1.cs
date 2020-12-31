using System;

namespace ClassLibrary1
{
    /// <summary>
    /// Class for Bank Account
    /// </summary>

    public class BankAccount
    {
        public int balance = 500;
        /// /// <summary>
        /// Method for withdrawing money from an account
        /// </summary>
        /// <param name="how_much">How much money to take from the account.</param>

        public void TakeMoney(int how_much)
        {

            if (this.balance < how_much)
            {
                Console.WriteLine("Exception:NotEnoughMoneyException");
            }
            else if (how_much < 0)
            {
                Console.WriteLine("Exception:NegativeAmountException");
            }
            else
            {
                this.balance -= how_much;
            }
        }
    }
}
