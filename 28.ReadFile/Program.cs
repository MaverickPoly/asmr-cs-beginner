internal class Program
{
    private static string filename = "text.txt";
    public static void Main(string[] args)
    {
        // ReadLines();
        // ReadText();
        // ReadStream();
    }

    private static void ReadLines()
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
            Console.WriteLine(line);
    }

    private static void ReadText()
    {
        string text = File.ReadAllText(filename);
        Console.WriteLine(text);
    }
    
    // Utilize StreamReader class
    private static void ReadStream()
    {
        using StreamReader stream = new StreamReader(filename);
        int count = 0;
        string line;
        Console.WriteLine("Reading");
        while ((line = stream.ReadLine() ?? "") != null)
        {
            Console.WriteLine(line);
            count++;
        }
        stream.Close();
        Console.WriteLine($"Read {count} lines in a file!");
    }
}