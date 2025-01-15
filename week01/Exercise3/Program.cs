using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 101);

        int guessNumber = -1;
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
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