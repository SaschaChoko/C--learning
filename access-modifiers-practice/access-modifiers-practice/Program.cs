class BankAccount
{
    private decimal balance;
    public string Owner = "default";

    public void Deposit(decimal amount)
    {
        this.balance = this.balance + amount;
        Console.WriteLine($"{amount}$ successfully transferred");
    }
    public void Withdraw(decimal amount)
    {
        this.balance = this.balance - amount;
        Console.WriteLine($"{amount}$ successfully recalled");
    }
    public decimal GetBalance()
    {
        Console.WriteLine("Your balance: " + balance + "$");
        return this.balance;       
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new();

        Console.WriteLine("Welcome to your bank account");
        Console.WriteLine("Please enter your name:");
        account.Owner = Console.ReadLine();
        bool activeSession = true;

        while (activeSession)
        {
            PrintFunctions();
            int desiredAction = Convert.ToInt32(Console.ReadLine());

            switch (desiredAction)
            {
                case 1:
                    Console.WriteLine("How much do you wanna deposit?");
                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                    account.Deposit(deposit);
                    break;

                case 2:
                    Console.WriteLine("How much do you wanna withdraw?");
                    decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;

                case 3:
                    account.GetBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using our bank!");
                    activeSession = false;
                    break;

                default:
                    Console.WriteLine($"There is no {desiredAction} function, please try again:");
                    break;
            }
        }
        static void PrintFunctions()
        {
            Console.WriteLine("Please enter desired action:");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - See the balance");
            Console.WriteLine("4 - Exit");
        }
    }
}