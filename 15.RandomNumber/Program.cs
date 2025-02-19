internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the random number guessing game!");
        Console.WriteLine("Guess the number between 0 and 100!");
        Random random = new Random();
        while (true)
        {
            int randomNumber = random.Next(0, 100);
            int attempts = 0, guess;
            
            Console.WriteLine();
            
            while (true)
            {
                Console.Write("Take a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess == randomNumber)
                {
                    Console.WriteLine($"Correct!\nThe answer was {randomNumber}");
                    Console.WriteLine($"It took you {attempts} guesses to find it!");
                    break;
                } else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }
            }
            
            Console.Write("Do you want to play again?(y/n): ");
            var again = Console.ReadLine();
            if (again.ToLower().Equals("n"))
            {
                break;
            }
        }
        Console.WriteLine("\nThanks for playing our game!");
    }
}
