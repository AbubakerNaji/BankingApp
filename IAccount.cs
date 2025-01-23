namespace BankingApp
{
    public interface IAccount
    {
        double Deposit(double amount);
        double Withdraw(double amount);
        double Balance { get; }
    }
}