class ListingActivity : BaseActivity
{
  
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "List the good things in your life") { }

    public override void PerformActivity()
    {
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"\nList as many items as you can: {prompt}");
        ShowPause(3);

        int itemsListed = GetItemsListed();
        Console.WriteLine($"\nYou listed {itemsListed} items.");
        ShowPause(3);
    }

    private int GetItemsListed()
    {
        int itemsListed = 0;
        DateTime startTime = DateTime.Now;

        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            Console.Write("Begin listing: ");
            string item = Console.ReadLine();

            if (!string.IsNullOrEmpty(item))
            {
                itemsListed++;
                ShowSpinner(1);
            }
        }

        return itemsListed;
    }
}