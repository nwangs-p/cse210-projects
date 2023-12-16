class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void DisplayTasks()
    {
        foreach (var task in tasks)
        {
            task.DisplayDetails();
        }
    }
}
