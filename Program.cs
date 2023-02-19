using System;

namespace StaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount.InterestRate = BankAccount.CalculateNewInterestRate();

            BankAccount account1 = new BankAccount(200);
            BankAccount account2 = new BankAccount(1200);

            account1.IncreaseAmout();
            account2.IncreaseAmout();

            Console.WriteLine(account1.GetAmount());
            Console.WriteLine(account2.GetAmount());
        }
    }
}
