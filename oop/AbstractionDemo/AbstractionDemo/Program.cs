using System;
namespace AbstractionDetail
    // implementing abstraction using interface 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            IBank sbi = BankFactory.GetBankeObject("SBI");
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.MiniStatement();
            sbi.CheckBalance();
            sbi.BankTransfer();

            Console.WriteLine("\nTransaction doing SBI Bank");
            IBank axix = BankFactory.GetBankeObject("SBI");
            axix.ValidateCard();
            axix.WithdrawMoney();
            axix.MiniStatement();
            axix.CheckBalance();
            axix.BankTransfer();
        }
    }
    
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalance();
        void BankTransfer();
        void MiniStatement();
    }

    public class BankFactory
    {
        IBank BankObject = null;
        public static IBank GetBankeObject (string BankType)
        {
            IBank BankObject = null;
            if(BankType == "SBI")
            {
                BankObject = new SBI();
            } return BankObject;
        }
    }

    public class SBI : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public void CheckBalance()
        {
            Console.WriteLine("SBI Bank CheckBalance");
        }

        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank ValidateCard");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank WithdrawMoney");
        }
    }

    public class AXIX : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public void CheckBalance()
        {
            Console.WriteLine("AXIX Bank CheckBalance");
        }

        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank ValidateCard");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank WithdrawMoney");
        }
    }
}