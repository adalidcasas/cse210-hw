using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("scriptures.txt");

        string quit = "";
        bool anyIsShowing = true;

        while (quit != "quit" && anyIsShowing)
        {
            Console.Clear();
            Console.WriteLine($"[{scripture.GetReference().GetDisplayText()}]: {scripture.GetDisplayText()}\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            quit = Console.ReadLine();

            anyIsShowing = !scripture.IsCompletelyHidden();
            scripture.HideRandomsWords(10);
        }
    }
}