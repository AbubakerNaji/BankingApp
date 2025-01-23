namespace BankingApp
{
    public class SavingAcount:IAccount
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public SavingAcount(){
            balance = 1000;
        }
        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        public double Withdraw(double amount)
        {
            if (amount < balance)
            {
                if( balance - amount < 1000)
                {
                    Console.WriteLine("You can't withdraw below 1000");
                }else{
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful");
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
            return balance;
        }
    }

}