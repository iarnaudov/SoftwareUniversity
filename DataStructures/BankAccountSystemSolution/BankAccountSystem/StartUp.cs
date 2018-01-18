using BankAccountSystem.Models;

namespace BankAccountSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DepositAccount deposit = new DepositAccount(Client.Individual, 800m, 2.35m);

            CreditAccount credit = new CreditAccount(Client.Company, 1200.34m, 4.56m);

            Mortgage mortgage = new Mortgage(Client.Company, 15000.23m, 6.57m);

            decimal rate = mortgage.CalculateInterest(11);
        }
    }
}
