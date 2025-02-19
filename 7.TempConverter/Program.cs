internal class TempConverter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to temperature converter app!");
        
        while (true)
        {
            Console.Write("\n1.F -> C\n2.C -> F\nSelect an option: ");
            var option = Convert.ToInt32(Console.ReadLine());

            if (option != 1 && option != 2)
            {
                Console.WriteLine("Invalid input!");
                continue;
            }
            
            Console.Write("Enter the temperature: ");
            var temp = Convert.ToDouble(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{temp} °F = {fahrToCel(temp)} °C");
                    break;
                case 2:
                    Console.WriteLine($"{temp} °C = {celToFahr(temp)} °F");
                    break;
                default:
                    Console.WriteLine("Invalid option! Please try again!");
                    break;
            }
            
            Console.Write("Do you want to calculate again?(y/n): ");
            var again = Console.ReadLine() ?? "";
            if (again.ToLower().Equals("n"))
            {
                break;
            }
        }
        
        Console.WriteLine("\nThanks for converter temperature!");
    }

    private static double celToFahr(double temp)
    {
        return temp * 9 / 5 + 32;
    }

    private static double fahrToCel(double temp)
    {
        return (temp - 32) * 5 / 9;
    }
}
