internal class AgeCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("In which year you were born?: ");
        var year = Convert.ToInt32(Console.ReadLine());
        var currentYear = DateTime.Now.Year;

        if (year > currentYear)
        {
            Console.WriteLine("The year is in the future!");
            return;
        }
        Console.WriteLine($"You are {currentYear - year} years old.");
        Console.WriteLine($"Now: {DateTime.Now.Year}");
    } 
}
