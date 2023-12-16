using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

    

        TaskManager taskManager = new TaskManager();

        Console.WriteLine("Enter the number of tasks you want to add:");
        if (int.TryParse(Console.ReadLine(), out int numTasks))
        {
            for (int i = 0; i < numTasks; i++)
            {
                Console.WriteLine($"Enter details for Task {i + 1}:");

                Console.Write("Title: ");
                string title = Console.ReadLine();

                Console.Write("Task Type (1 - Simple, 2 - Deadline, 3 - Long Term, 4 - Personal): ");
                if (int.TryParse(Console.ReadLine(), out int taskType))
                {
                    Task task;

                   switch (taskType)
                    {
                        case 1:
                            task = new SimpleTask(title);
                            break;

                        case 2:
                            Console.Write("Enter Deadline (yyyy-MM-dd): ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime deadline))
                            {
                                task = new DeadlineTask(title, deadline);
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format. Please enter a valid date.");
                                i--; // Decrement the loop counter to re-enter task details
                                continue;
                            }
                            break;

                        case 3:
                            Console.Write("Enter Months to Complete: ");
                            if (int.TryParse(Console.ReadLine(), out int monthsToComplete) && monthsToComplete >= 0)
                            {
                                task = new LongTermTask(title, monthsToComplete);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a non-negative integer for months to complete.");
                                i--; // Decrement the loop counter to re-enter task details
                                continue;
                            }
                            break;

                        case 4:
                            Console.Write("Enter Assigned To: ");
                            string assignedTo = Console.ReadLine();
                            task = new PersonalTask(title, assignedTo);
                            break;

                        default:
                            Console.WriteLine("Invalid task type. Please enter a number between 1 and 4.");
                            i--; // Decrement the loop counter to re-enter task details
                            continue;
                    }

                    taskManager.AddTask(task);
                }
                
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Skipping task.");
            Console.WriteLine("Invalid input. Exiting program.");
        }

        Console.WriteLine("\nTasks Added:");
        taskManager.DisplayTasks();
    }
}