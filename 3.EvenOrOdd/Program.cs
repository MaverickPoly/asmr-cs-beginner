// 3. Even Or Odd checker

internal class EvenOrOdd
{
    public static void Main()
    {
        Console.Write("Enter a number to check: ");
        var number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsOdd(number) ? $"Number {number} is Odd" : $"Number {number} is Even");
    }

    private static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
