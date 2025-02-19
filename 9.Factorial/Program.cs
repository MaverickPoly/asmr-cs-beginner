internal class Factorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Factorial of 5: {GetFactorial(5)}");
        Console.WriteLine($"Factorial of 10: {GetFactorial(10)}");
        Console.WriteLine($"Factorial of 15: {GetFactorial(15)}");
        
        Console.Write("\nEnter the number of factorial numbers: ");
        var n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Result:");
        foreach (var el in GenerateFactorial(n))
        {
            Console.Write(el + " ");
        }
    }

    private static long[] GenerateFactorial(int n)
    {
        long[] sequence = new long[n];
        for (int i = 1; i <= n; i++)
        {
            sequence[i - 1] = GetFactorial(i);
        }

        return sequence;
    }
    
    private static long GetFactorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * GetFactorial(number - 1);
    }
}
