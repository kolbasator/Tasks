using System;

namespace ClassLibrary1
{

    public class BankAccount
    {
        public int Balance = 500;


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
