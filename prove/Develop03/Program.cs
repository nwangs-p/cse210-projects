using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        while (true)
        {
            Console.WriteLine("Press Enter to get a random scripture or type 'quit' to end.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            Console.Clear();
            Scripture randomScripture = scriptureLibrary.GetRandomScripture();
            Console.WriteLine(randomScripture.GetDisplayText());

            while (!randomScripture.AllWordsHidden)
            {
                Console.WriteLine("Press Enter to hide words or type 'quit' to end.");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;

                Console.Clear();
                randomScripture.HideRandomWords();
                Console.WriteLine(randomScripture.GetDisplayText());
            }
        }

        Console.WriteLine("Program ended.");
    }
}