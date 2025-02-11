using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Order order01 = new Order();
        Customer customer1 = new Customer("Ryann Burnett", "865 Buck Drive", "Cottonwood", "Utah", "USA");
        order01.SetCustomer(customer1);
        order01.AddProduct("Laptop: Dell XPS 13", 1199);
        order01.AddProduct("Smartphone: Samsung Galaxy S23", 799);
        order01.AddProduct("Smartwatch: Garmin Venu 2", 399, 2);

        Order order02 = new Order();
        Customer customer2 = new Customer("Jeremy Osborne", "Maximilianstrabe 35", "Munich", "Bavaria", "Germany");
        order02.SetCustomer(customer2);
        order02.AddProduct("Wireless Speaker: JBL Flip 6", 129, 3);
        order02.AddProduct("E-Reader: Kindle Paperwhite", 159);
        order02.AddProduct("Portable Charger: Anker PowerCore 20,000 mAh", 59, 6);

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order01.GetPackingLabelList());
        Console.WriteLine(order01.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Order: ${order01.GetTotalCostOrder()}");
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order02.GetPackingLabelList());
        Console.WriteLine(order02.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Order: ${order01.GetTotalCostOrder()}");
        Console.WriteLine();
    }
}