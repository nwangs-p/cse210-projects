using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        EternalQuestProgram program = new EternalQuestProgram();

        while (true)
        {
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice (1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal type (simple/eternal/checklist): ");
                    string goalType = Console.ReadLine();
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int points = int.Parse(Console.ReadLine());
                    
                    if (goalType.ToLower() == "checklist")
                    {
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        program.CreateGoal(goalType, name, points, targetCount);
                    }
                    else
                    {
                        program.CreateGoal(goalType, name, points);
                    }
                    break;

                case "2":
                    Console.Write("Enter goal index to record event: ");
                    int goalIndex = int.Parse(Console.ReadLine());
                    program.RecordEvent(goalIndex);
                    break;

                case "3":
                    program.DisplayGoals();
                    break;

                case "4":
                    program.DisplayScore();
                    break;

                case "5":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    program.SaveGoals(saveFilename);
                    break;

                case "6":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    program.LoadGoals(loadFilename);
                    break;

                case "7":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    break;
            }

            Console.WriteLine(); // Add a newline for better readability
        }
    }
}