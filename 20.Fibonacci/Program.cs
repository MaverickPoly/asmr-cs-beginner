internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        var res = GenerateFibonacci(n);
        Console.WriteLine();
        foreach (var el in res)
            Console.Write($"{el} ");
    }

    private static long[] GenerateFibonacci(int length)
    {
        long[] res = new long[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{res[i]} ");
            res[i] = FibonacciN(i);
        }
        return res;
    }

    private static long FibonacciN(int n)
    {
        if (n <= 1)
            return 1;
        return FibonacciN(n - 1) + FibonacciN(n - 2);
    }
}