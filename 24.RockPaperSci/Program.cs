internal class Program
{
    public static void Main(string[] args)
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();
        int playerScore = 0, computerScore = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Rock, Paper, Scissors ====");
            Console.WriteLine("Score - You: {0} | Computer: {1}", playerScore, computerScore);
            Console.Write("Enter rock, paper or sci (or 'exit' to quit): ");
            string playerChoice = Console.ReadLine() ?? "";
            
            if (playerChoice == "exit")
            {
                Console.WriteLine("Thanks for playing! Final Score - You: {0} | Computer: {1}", playerChoice, computerScore);
                break;
            }

            if (Array.IndexOf(choices, playerChoice) == -1)
            {
                Console.WriteLine("Invalid Choice! Try again!");
                continue;
            }
            
            string computerChoice = choices[random.Next(choices.Length)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                     (playerChoice == "paper" && computerChoice == "rock") ||
                     (playerChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Computer wins!");
                computerScore++;
            }
            
            Console.WriteLine("\nPress any key to play again...");
            Console.ReadKey();
        }
    }
}