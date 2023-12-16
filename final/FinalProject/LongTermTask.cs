class LongTermTask : Task
{
    public int MonthsToComplete { get; set; }

    public LongTermTask(string title, int monthsToComplete)
    {
        Title = title;
        MonthsToComplete = monthsToComplete;
        IsComplete = false;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Long Term Task] {Title} - Months to Complete: {MonthsToComplete} - Complete: {IsComplete}");
    }
}