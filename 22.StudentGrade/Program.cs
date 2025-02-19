internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this student app!");
        Console.WriteLine("First, lets get some information about you.\n");
        Console.Write("What is your name? ");
        var name = Console.ReadLine() ?? "";
        List<int> grades = [];
        Console.Clear();
        Console.WriteLine("Enter your grades one by one or 'q' to quit.");
        while (true)
        {
            Console.Write("Enter a grade: ");
            var input = Console.ReadLine() ?? "";
            if (input.ToLower().Equals("q"))
                break;
            int grade = Convert.ToInt32(input);
            grades.Add(grade);
        }

        var averageGrade = GetAverage(grades);
        var res = GetGrade(averageGrade);
        Console.WriteLine($"\n{name}'s average grade is: {averageGrade}");
        Console.WriteLine($"{name}'s full grade is: {res}");
    }

    private static int GetAverage(List<int> grades)
    {
        return grades.Sum() / grades.Count;
    }

    private static string GetGrade(int averageGrade)
    {
        return averageGrade switch
        {
            > 90 => "A",
            > 80 => "B",
            > 70 => "C",
            > 60 => "D",
            > 50 => "E",
            _ => "F"
        };
    }
}
