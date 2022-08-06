using Console.Test._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double beginningBalnce = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            var account = new BankAccount("Mr Bryan Walton", beginningBalnce);

            //Act
            account.Debit(debitAmount);


            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }
    }
}
