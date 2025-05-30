using Bank.Domain;
using NUnit.Framework;

namespace Bank.Domain.Tests
{
    public class BankAccountTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // Act
            account.Debit(debitAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [Test]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            var account = new BankAccount("Bryan", 11.99);
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Debit(-100));
        }

        [Test]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(BankAccount.DebitAmountExceedsBalanceMessage, e.Message);
            }
        }
        [Test]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            var account = new BankAccount("Bryan", 10.00);
            account.Credit(5.00);
            Assert.AreEqual(15.00, account.Balance, 0.001);
        }
        [Test]
        public void Credit_WhenAmountIsNegative_ShouldThrowArgumentOutOfRange()
        {
            var account = new BankAccount("Bryan", 10.00);
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Credit(-5.00));
        }


    }
}



