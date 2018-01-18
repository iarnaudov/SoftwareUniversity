namespace BankAccountSystem.Models
{
    internal class DepositAccount : BankAccount
    {
        public DepositAccount(Client client, decimal balance, decimal interestRate) 
            : base(client, balance, interestRate)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
        }
        public decimal Withdraw(decimal amount)
        {
           return this.Balance -= amount;
        }
    }
}
