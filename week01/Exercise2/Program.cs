using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string gradeletter = "";

        if (percent >= 90)
        {
            gradeletter = "A";
        }
        else if (percent >= 80)
        {
            gradeletter = "B";
        }
        else if (percent >= 70)
        {
            gradeletter = "C";
        }
        else if (percent >= 60)
        {
            gradeletter = "D";
        }
        else
        {
            gradeletter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeletter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}