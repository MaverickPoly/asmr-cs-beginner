internal class Program
{
    public static void Main(string[] args)
    {
        List<string> notes = [];
        Console.WriteLine("Welcome to this notes app!");
        bool running = true;
        
        while (running)
        {
            Console.Write("\n1.View all notes\n2.Add Note\n3.Delete Note\n4.Exit.\nSelect an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    DisplayNotes(notes);
                    break;
                case 2:
                    Console.Write("Enter the note content: ");
                    string content = Console.ReadLine() ?? "";
                    notes.Add(content);
                    Console.WriteLine("-----Added successfully!");
                    break;
                case 3:
                    DisplayNotes(notes);
                    Console.Write("Enter the index of note to delete: ");
                    int index = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (index <= 0 || index > notes.Count)
                        Console.WriteLine("There is no such note!");
                    else
                    {
                        notes.RemoveAt(index);
                        Console.WriteLine($"------Removed note with id {index - 1} successfully!");
                    }
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option! Please try again...");
                    break;
            }
        }
        Console.WriteLine("\nThanks for utilizing our service.");
    }

    private static void DisplayNotes(List<string> notes){
        Console.WriteLine("\n-----Notes: ");
        for (int i = 0; i < notes.Count; i++)
            Console.WriteLine($"{i + 1}.{notes[i]}");
    }
}