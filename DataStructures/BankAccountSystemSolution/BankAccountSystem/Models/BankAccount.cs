namespace BankAccountSystem.Models
{
    public abstract class BankAccount
    {
        public BankAccount(Client client, decimal balance, decimal interestRate)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        protected Client Client { get; set; }

        protected decimal Balance { get; set; }

        protected decimal InterestRate { get; set; }

        public virtual decimal Deposit(decimal amount)
        {
            return this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal calculatedInterestRate = this.InterestRate * months;
            return calculatedInterestRate;
        }
    }
}
