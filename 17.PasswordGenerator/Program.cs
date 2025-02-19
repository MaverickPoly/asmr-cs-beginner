internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of characters: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Include string?: ");
        bool isString = (Console.ReadLine() ?? "").ToLower().Equals("y");
        Console.Write("Include digits?: ");
        bool isDigit = (Console.ReadLine() ?? "").ToLower().Equals("y");
        Console.Write("Include punctuation?: ");
        bool isPunctuation = (Console.ReadLine() ?? "").ToLower().Equals("y");

        // Named arguments
        var password = GeneratePassword(isString, isPunctuation: isPunctuation, isDigit: isDigit, length: n);
        Console.WriteLine($"Password: {password}");
    }

    public static string GeneratePassword(bool isString = true, bool isDigit = true, bool isPunctuation=true, int length=10)
    {
        string values = "";
        Random rnd = new Random();
        if (isString)
            values += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        if (isDigit)
            values += "0123456789";
        
        if (isPunctuation)
            values += "!\"#$%&\\'()*+,-./:;<=>?@[\\\\]^_`{|}~";

        string password = "";
        for (int i = 0; i < length; i++)
            password += values[rnd.Next(0, values.Length - 1)];

        return password;
    }
}