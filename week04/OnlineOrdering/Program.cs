/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Online Ordering Programn - Main Program
    
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // We will format currency using en-US so that totals show with a $ sign.
        var usCulture = CultureInfo.GetCultureInfo("en-US");

        // -------------------------
        // First Order (Domestic)
        // -------------------------
        Address address1 = new Address(
            street: "123 Elm Street",
            city: "Seattle",
            stateOrProvince: "WA",
            country: "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("C# Programming Book", "B001", 29.99m, 1));
        order1.AddProduct(new Product("Notebook", "N100", 3.50m, 3)); // 3 notebooks at $3.50 each

        // -------------------------
        // Second Order (International)
        // -------------------------
        Address address2 = new Address(
            street: "456 Maple Ave",
            city: "Toronto",
            stateOrProvince: "Ontario",
            country: "Canada"
        );

        Customer customer2 = new Customer("Anna Kowalski", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Wireless Headphones", "H123", 59.99m, 1));
        order2.AddProduct(new Product("USB-C Charger", "C234", 19.99m, 2)); // 2 chargers

        // -------------------------
        // Display Orders
        // -------------------------
        List<Order> orders = new List<Order> { order1, order2 };

        int orderNumber = 1;
        foreach (var ord in orders)
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Order #{orderNumber}");
            Console.WriteLine(new string('-', 50));

            // Packing label
            Console.WriteLine(ord.GetPackingLabel());
            Console.WriteLine();

            // Shipping label
            Console.WriteLine(ord.GetShippingLabel());
            Console.WriteLine();

            // Total price (formatted as currency)
            decimal total = ord.CalculateTotalPrice();
            Console.WriteLine($"Total Price: {total.ToString("C", usCulture)}");

            Console.WriteLine(new string('=', 50));
            Console.WriteLine();
            orderNumber++;
        }

        // Pause to keep console window open if run outside of an IDE that auto-closes.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
