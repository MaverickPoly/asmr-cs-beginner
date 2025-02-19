internal class Program
{
    public static void Main(string[] args)
    {
        List<string> questions = [
            "What is the capital of France?", 
            "Who wrote Hamlet?",
            "What is the chemical symbol for gold?",
            "What planet is known as the Red Planet?",
            "What is the speed of light?",
            "Who invented the telephone?",
        ];
        
        List<string> options = [
            "Berlin", "Madrid", "Paris", "Rome",
            "Charles Dickens", "William Shakespeare", "Mark Twain", "Jane Austen",
            "Ag", "Au", "Pb", "Fe",
            "Earth", "Venus", "Mars", "Jupiter",
            "300.000", "150.000", "1.000", "3.000",
            "Nikola Tesla", "Thomas Edison", "Alexander Bell", "Albert Einstein",
        ];

        // indexes of correct answers
        List<int> answers = [
            2, 1, 1, 2, 0, 2
        ];
        
        Console.WriteLine("Welcome to this quiz app!");
        int score = 0;
        var start = DateTime.Now;

        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"\n========== Question {i} ==========");
            Console.WriteLine($"{questions[i]}");
            for (int j = 4 * i; j < 4 * i + 4; j++)
            {
                Console.WriteLine($"{j - 4 * i + 1}. {options[j]}");
            }
            Console.Write("Answer: ");
            int answerIndex = Convert.ToInt32(Console.ReadLine());
            if (answerIndex - 1 == answers[i])
            {
                score++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Wrong! The answer was {options[answers[i] + i * 4]}");
            }
        }
        Console.WriteLine("\nEnd of Quiz!");
        Console.WriteLine($"Your score is {score}/{answers.Count}");
        var end = DateTime.Now;
        var diff = end - start;
        Console.WriteLine($"Time taken: {diff.Seconds} seconds");
    }
}