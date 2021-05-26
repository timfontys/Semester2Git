using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigBucksBankWithoutExceptions;

namespace BigBucksBankWitouthExeptionsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NoInformationGivenExeption))]
        public void TestNoInformationGivenExeption()
        {
            decimal initialBalance;
                initialBalance = Convert.ToDecimal(100);
                Account account = new Account("", initialBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughMoneyExeption))]
        public void TestEnoughMoneyExeption() 
        {
            Account account = new Account("Tim", 1000);
            account.Withdraw(3000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestArgumentNullExeption() 
        {
            Account account = new Account(null, 1000);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void testFOrmatExeption()
        {
            Account account = new Account("Tim", 1000);
            decimal amount;
            amount = Convert.ToDecimal("Tim");
            account.Deposit(amount);
        }
    }
}
