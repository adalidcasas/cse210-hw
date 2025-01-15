using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        int sum = 0;
        int max = numbers[0];
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}