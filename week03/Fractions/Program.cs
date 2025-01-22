using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(2, 3);

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.DecimalValue());

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.DecimalValue());

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.DecimalValue());

        Fraction frac4 = new Fraction();
        frac4.SetTop(3);
        frac4.SetBottom(4);
        Console.WriteLine(frac4.GetTop());
        Console.WriteLine(frac4.GetBottom());

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.DecimalValue());
    }
}