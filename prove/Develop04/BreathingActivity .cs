class BaseActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public BaseActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity(int duration)
    {
        Console.WriteLine($"\nStarting {name} - {description}");
        SetDuration(duration);
        PrepareToBegin();
        PerformActivity();
        FinishActivity();
    }

    protected void SetDuration(int duration)
    {
        this.duration = duration;
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    protected void FinishActivity()
    {
        Console.WriteLine($"\nGood job! You have completed {name}");
        ShowPause(3);
    }

    protected void ShowPause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public virtual void PerformActivity()
    {
        //override by derived classes
    }
}

class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by focusing on breathing") { }

    public override void PerformActivity()
    {
        Console.WriteLine("Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i++)
        {
            double progress = (double)i / duration;

            BreatheInOut(progress);
        }

        Console.WriteLine("\nBreathe in... Breathe out..."); 
        ShowPause(3);
    }

    private void BreatheInOut(double progress)
    {
        Console.Clear();

        // Calculate the animation duration based on progress
        int animationDuration = (int)(duration * (1 - Math.Abs(2 * progress - 1)));

        // Display the growing animation
        for (int i = 1; i <= animationDuration; i++)
        {
            Console.WriteLine(new string(' ', i) + "Breathe in...");
            ShowPause(1);
            Console.Clear();
        }

        // Display the slowing down animation
        for (int i = animationDuration; i >= 1; i--)
        {
            Console.WriteLine(new string(' ', i) + "Breathe out...");
            ShowPause(1);
            Console.Clear();
        }
    }
}