internal class Program
{
    private static Dictionary<string, string> users = new Dictionary<string, string>();
    
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Login System ====");
            Console.WriteLine("1.Register");
            Console.WriteLine("2.Login");
            Console.WriteLine("3.Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Register();
                    break;
                case "2":
                    Login();
                    break;
                case "3":
                    Console.WriteLine("Exiting... Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again!");
                    break;
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private static void Register()
    {
        Console.Write("Enter a username: ");
        string username = Console.ReadLine() ?? "";

        if (users.ContainsKey(username))
        {
            Console.WriteLine("Username already exists! Try another.");
            return;
        }

        if (username.Length == 0)
        {
            Console.WriteLine("Username is required!");
            return;
        }
        Console.Write("Enter a password: ");
        string password = Console.ReadLine() ?? "";

        if (password.Length == 0)
        {
            Console.WriteLine("Password is required!");
            return;
        }

        users[username] = password;
        Console.WriteLine("Registration successful! You can login now!");
    }

    private static void Login()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine() ?? "";
        
        Console.Write("Enter your password: ");
        string password = Console.ReadLine() ?? "";

        if (users.ContainsKey(username) && users[username] == password)
        {
            Console.WriteLine($"Login successful! Welcome, {username}!");
        }
        else
        {
            Console.WriteLine("Invalid username or password! Try again!");
        }
    }
}