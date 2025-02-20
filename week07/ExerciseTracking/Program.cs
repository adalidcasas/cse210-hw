using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Running running = new Running(DateTime.Today, 30, 3);
        Console.WriteLine(running.GetSummary());
        Console.WriteLine();
        Cycling cycling = new Cycling(DateTime.Today, 60, 5);
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine();
        Swimming swimming = new Swimming(DateTime.Today, 120, 20);
        Console.WriteLine(swimming.GetSummary());
    }
}