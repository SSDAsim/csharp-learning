using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Starts with a balance of 500
            BankAccount myAccount = new BankAccount(300);

            myAccount.Deposit(400);
            Console.WriteLine(myAccount.Balance);

            myAccount.Withdraw(100);
            Console.WriteLine(myAccount.Balance);

            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        // access from outside class is not allowed
        private decimal balance;
        
        //only allow retrieving the balance
        public decimal Balance
        {
            get { return balance; }
        }

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance <= 0)
            {
                throw new ArgumentException("Initial balance can not be negative");
            }

            balance = initialBalance;
        }

        public void Deposit (decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount to be deposited can not be negative");
            }

            balance += amount;
        }

        public void Withdraw (decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount to be withdrawn can not be negative");
            }

            if ( balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }

            balance -= amount;
        }
    }
}
