namespace BankAccountSystem.Models
{
    internal class CreditAccount : BankAccount
    {
        public CreditAccount(Client client, decimal balance, decimal interestRate) 
            : base(client, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal calculatedInterest = 0;
            if (this.Client == Client.Individual)
            {
                calculatedInterest = base.CalculateInterest(months) - base.CalculateInterest(3);
            }
            else if (this.Client == Client.Company)
            {
                calculatedInterest = base.CalculateInterest(months) - base.CalculateInterest(2);
            }
            if (calculatedInterest < 0)
            {
                return 0;
            }
            return calculatedInterest;
        }
    }
}
