internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        var input = Console.ReadLine() ?? "";
        int count = CountLetters(input);
        Console.WriteLine($"Number of letters in a sentence: {count}");
    }

    private static int CountLetters(string str)
    {
        int count = 0;
        var splitted = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (var el in splitted)
        {
            count += el.Length;
        }
        return count;
    }
}
