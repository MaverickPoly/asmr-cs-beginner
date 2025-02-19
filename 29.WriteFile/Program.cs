internal class Program
{
    private static string text = "Hello world! This is a sample test of writing a text into a file!";
    private static string filename = "text.txt";
    
    public static void Main(string[] args)
    {    
        // WriteLines();
        // WriteText();
        // WriteStream();
    }

    private static void WriteLines()
    {
        File.WriteAllLines(filename, text.Split("\n", StringSplitOptions.RemoveEmptyEntries));
        Console.WriteLine($"Wrote lines to file {filename} successfully!");
    }

    private static void WriteText()
    {
        File.WriteAllText(filename, text);
        Console.WriteLine($"Wrote text to file {filename} successfully!");
    }

    private static void WriteStream()
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(text);
        writer.WriteLine("This is the end!");
        
        writer.Close();
        Console.WriteLine($"Wrote data in stream to file {filename} successfully!");
    }
}