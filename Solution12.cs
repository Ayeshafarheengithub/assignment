using System;
namespace Assignment
{
    abstract class Account
    {
        public int AccountNo { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; private set; } = 1000;
        public void Credit(double amount) => Balance += amount;

        public void Debit(double amount)
        {
            if (Balance < amount)
            {
                throw new Exception("Insufficient funds!!!");
            }
            Balance -= amount;
        }

        public abstract void CalculateInterest();

    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            double principle = Balance;
            double rate = 0.065;
            double term = 0.5;// Half yearly

            var interest = principle * rate * term;
            Credit(interest);
        }
    }
    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            double principle = Balance;
            double rate = 0.062;
            double term = 0.5;// Half yearly

            var interest = principle * rate * term;
            Credit(interest);
        }
    }
    class RDAccount : Account
    {
        public override void CalculateInterest()
        {
            double principle = Balance;
            double rate = 0.053;
            double term = 0.5;// Half yearly

            var interest = principle * rate * term;
            Credit(interest);
        }
    }
    class AbstractClassExample
    {
        static void Main(string[] args)
        {
            Account SBacc = new SBAccount();
            Account FDacc = new FDAccount();
            Account RDacc = new RDAccount();
            SBacc.AccountNo = 9969;
            SBacc.HolderName = "SB Account Holder";
            SBacc.CalculateInterest();
            Console.WriteLine("The Current balance of SB account is : " + SBacc.Balance);
            FDacc.AccountNo = 0814;
            FDacc.HolderName = "FD Account Holder";
            FDacc.CalculateInterest();
            Console.WriteLine("The Current balance of FD account is : " + FDacc.Balance);
            RDacc.AccountNo = 1234;
            RDacc.HolderName = "RD Account Holder";
            RDacc.CalculateInterest();
            Console.WriteLine("The Current balance of RD account is : " + RDacc.Balance);
        }
    }
}