using NUnit.Framework;
using ClassLibrary1;
namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]

        public void Setup()
        {
        }

        [Test]
        public void TakeMoneyTest()
        {
            bool result = BankAccount.TakeMoney(-1);
            Assert.IsFalse(result, "Error:negative amount of money.");

            bool result2 = BankAccount.TakeMoney(BankAccount.Balance += 1);
            Assert.IsFalse(result, "Error:there is not so much money on the account.");

            bool result3 = BankAccount.TakeMoney(BankAccount.Balance);
            Assert.IsFalse(result, "The money was withdrawn.");
        }
    }
}