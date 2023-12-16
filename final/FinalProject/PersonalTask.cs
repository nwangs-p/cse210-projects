class PersonalTask : Task
{
    public string AssignedTo { get; set; }

    public PersonalTask(string title, string assignedTo)
    {
        Title = title;
        AssignedTo = assignedTo;
        IsComplete = false;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Personal Task] {Title} - Assigned to: {AssignedTo} - Complete: {IsComplete}");
    }
}
