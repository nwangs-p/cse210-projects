class SimpleTask : Task
{
    public SimpleTask(string title)
    {
        Title = title;
        IsComplete = false;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Simple Task] {Title} - Complete: {IsComplete}");
    }
}
