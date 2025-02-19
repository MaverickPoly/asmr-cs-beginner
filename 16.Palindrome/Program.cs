internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it is palindrome: ");
        var input = Console.ReadLine();
        if (IsPalindrome(input))
        {
            Console.WriteLine($"Word {input} is Palindrome");
        }
        else
        {
            Console.WriteLine($"Word {input} is NOT Palindrome");
        }
    }

    private static bool IsPalindrome(string input)
    {
        return input.Equals(Reverse(input));
    }

    private static string Reverse(string str)
    {
        return new string(str.ToCharArray().Reverse().ToArray());
    }
}