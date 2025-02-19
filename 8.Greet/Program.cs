internal class GreetUser
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name: ");
        var name = Console.ReadLine()!;
        
        Console.Write("What is your age: ");
        var age = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Where are you from: ");
        var city = Console.ReadLine()!;
        
        Greet(name, age, city);
    }

    private static void Greet(string name, int age, string city)
    {
        Console.WriteLine($"Hello, {name}, you are {age} years old and live in {city}!");
    }
}