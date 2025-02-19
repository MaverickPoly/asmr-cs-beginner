internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        var input = Console.ReadLine() ?? "";
        
        Console.WriteLine($"Number of words: {CountWords(input)}");
    }

    private static int CountWords(string str)
    {
        string[] chars = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return chars.Length;
    }
}