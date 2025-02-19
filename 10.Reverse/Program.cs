internal class ReverseProgram
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string to reverse: ");
        var input = Console.ReadLine() ?? "";
        Console.WriteLine($"Reversed: {Reverse(input)}");
    }

    protected static string Reverse2(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    private static string Reverse(string str)
    {
        char[] charArr = str.ToCharArray();
        string reversed = string.Empty;

        for (int i = charArr.Length - 1; i >= 0; i--)
        {
            reversed += charArr[i];
        }

        return reversed;
    }
}