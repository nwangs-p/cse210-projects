class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    private int currentCount;

    public ChecklistGoal(string name, int points, int targetCount)
    {
        Name = name;
        Points = points;
        TargetCount = targetCount;
        currentCount = 0;
    }

    public override int MarkComplete()
    {
        currentCount++;
        if (currentCount == TargetCount)
        {
            Completed = true;
            return Points + 500; // Bonus points on completion
        }
        return Points;
    }

    public string GetProgress()
    {
        return $"Completed {currentCount}/{TargetCount} times";
    }
}

class EternalQuestProgram
{
    private List<Goal> goals;
    private int userScore;

    public EternalQuestProgram()
    {
        goals = new List<Goal>();
        userScore = 0;
    }

    public void CreateGoal(string goalType, string name, int points, int targetCount = 0)
    {
        Goal goal;
        switch (goalType.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, points);
                break;
            case "checklist":
                goal = new ChecklistGoal(name, points, targetCount);
                break;
            default:
                throw new ArgumentException("Invalid goal type");
        }
        goals.Add(goal);
    }

    public bool RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            if (!goal.Completed)
            {
                userScore += goal.MarkComplete();
                return true;
            }
            else
            {
                Console.WriteLine("Goal already completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
        return false;
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            string status = goal.Completed ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{status} {goal.Name}: {checklistGoal.GetProgress()}");
            }
            else
            {
                Console.WriteLine($"{status} {goal.Name}");
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"User Score: {userScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Points},{goal.Completed}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int points = int.Parse(parts[1]);
                bool completed = bool.Parse(parts[2]);

                Goal goal;
                if (completed)
                {
                    goal = new SimpleGoal(name, points);
                    goal.Completed = true;
                }
                else
                {
                    goal = new SimpleGoal(name, points);
                }

                goals.Add(goal);
            }
        }
    }
}
