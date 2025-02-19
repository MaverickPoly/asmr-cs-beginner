internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the n(how many numbers you want to enter): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter numbers one by one\n");
        
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        
        Console.Write("What number would you like to search: ");
        int target = Convert.ToInt32(Console.ReadLine());
        int foundIndex = FindIndex(numbers, target);

        if (foundIndex != -1)
            Console.WriteLine($"{target} found at index {foundIndex}");
        else
            Console.WriteLine("That element cannot be found");
        Console.WriteLine();
        foreach (var num in numbers)
            Console.Write(num + " ");
    }

    private static int FindIndex(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(target))
                return i;
        }
        return -1;
    }
}