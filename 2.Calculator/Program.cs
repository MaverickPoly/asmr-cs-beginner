// 2. Calculator

class Calculator
{
    public static void Main()
    {
        Console.WriteLine("Welcome to this calculator app!\n");
        int option;
        double number1, number2;
        string[] options = {"Addition", "Subtraction", "Multiplication", "Division"};
        
        while (true)
        {
            Console.Write("\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\nSelect an option: ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
            Console.WriteLine($"\n{options[option - 1]}:");

            if (option != 1 & option != 2 & option != 3 & option != 4)
            {
                Console.WriteLine("Invalid option! Please try again!");
                continue;
            }

            try
            {
                Console.Write("Enter number 1: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2: ");
                number2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                    break;
                case 4:
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Invalid option! Please try again!");
                    break;
            }
            
            Console.Write("Do you want to calculate again?(y/n): ");
            string again = Console.ReadLine();

            if (again.ToLower().Equals("n"))
            {
                break;
                // goto end_of_loop;
            }
        }
        // end_of_loop:
        Console.WriteLine("Thanks for calculating!");
    }
}
