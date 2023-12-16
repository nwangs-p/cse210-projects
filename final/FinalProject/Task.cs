abstract class Task {
    public string Title { get; set; }
    public bool IsComplete { get; set; }

    // Polymorphism..
    public abstract void DisplayDetails();
}