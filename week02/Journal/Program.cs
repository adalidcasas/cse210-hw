using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the Journal Program!");
        Journal journal = new Journal();
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?... ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("WRITE");
                    Entry entry = new Entry();
                    journal.AddEntry(entry);
                    journal._entries.Add(entry);
                    break;
                case 2:
                    Console.WriteLine("DISPLAY");
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("LOAD");
                    Console.Write("What is the filename? ");
                    string file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    break;
                case 4:
                    Console.WriteLine("SAVE");
                    Console.Write("What is the filename? ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                case 5:
                    Console.WriteLine("QUIT");
                    Console.WriteLine("See you soon!");
                    break;
                default:
                    Console.WriteLine("Error! This option is not eligible. Please try again.");
                    break;
            }
            Console.WriteLine("");
        }
    }
}