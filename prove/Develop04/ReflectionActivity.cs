class ReflectionActivity : BaseActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflect on times of strength and resilience") { }

    public override void PerformActivity()
    {
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"\nReflect on: {prompt}");
        ShowPause(3);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
        }

        Console.WriteLine("\nReflection activity complete.");
        ShowPause(3);
    }
}