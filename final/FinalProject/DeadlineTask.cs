class DeadlineTask : Task
{
    public DateTime Deadline { get; set; }

    public DeadlineTask(string title, DateTime deadline)
    {
        Title = title;
        Deadline = deadline;
        IsComplete = false;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Deadline Task] {Title} - Deadline: {Deadline} - Complete: {IsComplete}");
    }
}