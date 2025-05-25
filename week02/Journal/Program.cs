using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Write your entry: ");
                string entryText = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(new Entry(date, prompt, entryText));
                Console.WriteLine("Entry added!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter file name to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                Console.WriteLine("Journal loaded!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting... Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}