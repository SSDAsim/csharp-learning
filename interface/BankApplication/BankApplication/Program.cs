using System;

namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Savings Account: ");
            IBankAccount savingAccount = new SavingAccount();
            savingAccount.DepositAmount(5000);
            savingAccount.WithdrawAmount(2000);
            savingAccount.DepositAmount(1000);
            savingAccount.WithdrawAmount(5000);
            Console.WriteLine($"The Balance in Saving Account is: {savingAccount.CheckBalance()}");

            Console.WriteLine("\nCurrent Account: ");
            IBankAccount currentAccount = new CurrentAccount();
            currentAccount.DepositAmount(5000);
            currentAccount.WithdrawAmount(2000);
            currentAccount.DepositAmount(1000);
            currentAccount.WithdrawAmount(5000);
            Console.WriteLine($"The Balance in Current Account is: {currentAccount.CheckBalance()}");
            Console.ReadLine();
        }
    }

    // interface 
    interface IBankAccount
    {
        bool DepositAmount(decimal amount);
        bool WithdrawAmount(decimal amount);
        decimal CheckBalance();
    }

    // savings account 
    public class SavingAccount : IBankAccount
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawLimit = 10000;
        private decimal TodayWithdrawal = 0;

        public bool DepositAmount(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Amount Deposited. New Balance is: {Balance}");
            return true;
        }

        public bool WithdrawAmount(decimal amount)
        {
            // check if the amount is greater than the available balance 
            if(amount > Balance)
            {
                Console.WriteLine("Insufficient Balance.");
                Console.WriteLine($"Available balance is: {Balance}");
                return false;
            } else if ((amount + TodayWithdrawal) > PerDayWithdrawLimit)
            {
                Console.WriteLine("Per Day Withdraw Limit exceeded");
                return false;
            } else
            {
                Balance = Balance - amount;
                TodayWithdrawal += amount;
                Console.WriteLine($"Amount successfully withdrawn from account: {amount}");
                Console.WriteLine($"New Balance is: {Balance}");
                return true;
            }
        }

        public decimal CheckBalance()
        {
            return Balance;
        }
    }

    // current account 
    public class CurrentAccount: IBankAccount
    {
        private decimal Balance = 0;

        public bool DepositAmount(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Amount Deposited. New Balance is: {Balance}");
            return true;
        }

        public bool WithdrawAmount(decimal amount)
        {
            // check if the amount is greater than the available balance 
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine($"Available balance is: {Balance}");
                return false;
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Amount successfully withdrawn from account: {amount}");
                Console.WriteLine($"New Balance is: {Balance}");
                return true;
            }
        }

        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
