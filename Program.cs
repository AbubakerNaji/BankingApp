// See https://aka.ms/new-console-template for more information
using BankingApp;

Console.WriteLine("banking app");
Console.WriteLine("1. Saving Account");
Console.WriteLine("2. Current Account");
Console.WriteLine("3. Exit");
Console.WriteLine("Enter your choice");
int choice = Convert.ToInt32(Console.ReadLine());
IAccount account = null;
switch (choice)
{
    case 1:
        Console.WriteLine("You have selected Saving Account.");
           account = new SavingAcount();
        break;
    case 2:
        Console.WriteLine("You have selected Current Account.");
        // Add logic for Current Account
        account = new CurrentAccount();
        break;
    case 3:
        Console.WriteLine("Exiting the application.");
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Invalid choice. Please enter a valid option.");
        break;
}

if (account != null)
{
    Console.WriteLine("Enter amount to deposit:");
    double depositAmount = Convert.ToDouble(Console.ReadLine());
    account.Deposit(depositAmount);
    Console.WriteLine($"New balance after deposit: {account.Balance}");

    Console.WriteLine("Enter amount to withdraw:");
    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
    account.Withdraw(withdrawAmount);
    Console.WriteLine($"New balance after withdrawal: {account.Balance}");
}
Console.WriteLine("Do you want to perform another transaction? (y/N)");
string anotherTransaction = Console.ReadLine().ToLower();

while (anotherTransaction == "y" && account != null)
{
    Console.WriteLine("Enter amount to deposit:");
    double depositAmount = Convert.ToDouble(Console.ReadLine());
    account.Deposit(depositAmount);
    Console.WriteLine($"New balance after deposit: {account.Balance}");

    Console.WriteLine("Enter amount to withdraw:");
    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
    account.Withdraw(withdrawAmount);
    Console.WriteLine($"New balance after withdrawal: {account.Balance}");

    Console.WriteLine("Do you want to perform another transaction? (yes/no)");
    anotherTransaction = Console.ReadLine().ToLower();
}
Console.WriteLine("Thank you for using the banking app.");
