namespace BankingApp
{
    public class CurrentAccount:IAccount
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        CurrentAccount(){
            balance = 20000;
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
              
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful");
                
            }else{
                Console.WriteLine("Insufficient funds");
            }
            return balance;
        }
    }

}