using System;

// implementing ABSTRACTION using abstract class and abstract methods
namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            IBank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalance();
            sbi.BankTransfer();
            sbi.MiniStatement();
            Console.WriteLine("\nTransaction doing AXIX Bank");
            IBank AXIX = BankFactory.GetBankObject("AXIX");
            AXIX.ValidateCard();
            AXIX.WithdrawMoney();
            AXIX.CheckBalance();
            AXIX.BankTransfer();
            AXIX.MiniStatement();
            Console.Read();
        }
    }

    public abstract class IBank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void MiniStatement();
        public abstract void BankTransfer();
        public abstract void CheckBalance();
    }

    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if(bankType == "SBI")
            {
                BankObject = new SBI();
            } else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }
    }

    public class SBI : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank ValidateCard");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("SBI Bank CheckBalance");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank WithdrawMoney");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank MiniStatement");
        }
    }

    public class AXIX : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank ValidateCard");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("SBI Bank CheckBalance");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank WithdrawMoney");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank MiniStatement");
        }
    }

}
