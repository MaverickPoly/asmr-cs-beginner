internal class Program
{
    public static void Main()
    {
        decimal balance = 1000.00m;
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== Simple ATM Simulator ====");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Your current balance is: ${balance}");
                    break;
                case "2":
                    Console.Write("Enter deposit amount: $");
                    if (decimal.TryParse(Console.ReadLine(), out decimal deposit) && deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine($"Deposited successfully! New balance: ${balance}");
                    }
                    else
                        Console.WriteLine("Invalid deposit amount!");
                    break;
                case "3":
                    Console.Write("Enter withdrawal amount: $");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdraw) && withdraw > 0)
                    {
                        if (withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine($"Withdrawal successful! Remaining balance: ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount!");
                    }
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Thank you for using this ATM!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, Please try again.");
                    break;
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}