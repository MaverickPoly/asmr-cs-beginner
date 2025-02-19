internal class Program
{
    public static void Main(string[] args)
    {
        List<int> l = [8, 2, 3, 7, 5, 4];
        // l.Add(8);
        // l.Add(2);
        // l.Add(3);
        // l.Add(7);
        // l.Add(5);
        // l.Add(4);
        
        DisplayList(l);
        // l = BuiltInSort(l);
        l = BubbleSort(l);
        DisplayList(l);
    }

    private static void DisplayList(List<int> list)
    {
        foreach (var val in list)
            Console.Write(val + " ");
        Console.WriteLine();
    }

    private static List<int> BuiltInSort(List<int> list)
    {
        list.Sort();
        return list;
    }

    private static List<int> BubbleSort(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            bool swapped = false;
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
        return list;
    }
}