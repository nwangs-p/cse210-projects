using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display the journal.");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit.");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry entry = new Entry(prompt, response, DateTime.Now);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile("Journal.txt");
                    break;
                case 4:
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile("Journal.txt");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}