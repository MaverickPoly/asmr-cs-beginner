
internal class MultTable
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        GenerateTable(n);
    }

    private static void GenerateTable(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write($"{i * j} ");
            }
            Console.WriteLine();
        }
    }
}