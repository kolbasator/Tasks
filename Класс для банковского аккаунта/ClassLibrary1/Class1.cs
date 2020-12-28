using System;

namespace ClassLibrary1
{ 

    public class BankAccount
    {
        public int balance = 500;

     
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
