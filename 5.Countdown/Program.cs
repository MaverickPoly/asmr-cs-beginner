internal class Countdown
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number of seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        if (seconds < 0)
        {
            Console.WriteLine("The number is negative.");
            return;
        }
        
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(seconds - i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Time is up!");
    }
}
