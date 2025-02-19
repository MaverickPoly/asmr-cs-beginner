internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of numbers: ");
        var n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine($"\nMin: {Min(numbers)}");
        Console.WriteLine($"Max: {Max(numbers)}");
        Console.WriteLine($"Sum: {Sum(numbers)}");
        Console.WriteLine($"Average: {Average(numbers)}");
    }

    private static int Max(int[] numbers)
    {
        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
        
    }

    private static int Min(int[] numbers)
    {
        int min = numbers[0];
        foreach (var num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }

    private static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    private static int Average(int[] numbers)
    {
        return Sum(numbers) / numbers.Length;
    }
}