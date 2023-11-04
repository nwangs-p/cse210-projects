using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1,11);

        int guess = -1;

             while (guess != num)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (num > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (num < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}