using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // creating the first order for a customer in Mexico and add 2 products
        Order order1 = new Order(new Customer("Marco Gonzalez", new Address("Los Tulipanes 0219", "Texcoco", "Mexico State", "Mexico")));
        order1.AddProduct(new Product("Pencil", "P3NC1 1", 5, 5));
        order1.AddProduct(new Product("Laptop", "L4PT O", 500, 2));

        // Displaying the total cost and labels
        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalPrice()}");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();

        // Creating the second order for a customer in USA and add products
        Order order2 = new Order(new Customer("Antony Smith", new Address("9919 Palm St", "Tucson", "Arizona", "USA")));
        order2.AddProduct(new Product("Iphone", "APP13 15", 500.75, 2));
        order2.AddProduct(new Product("Note Book", "N0T3 22", 10, 5));
        order2.AddProduct(new Product("Calculator", "C41CU 01", 50.5, 3));
       
        // Displaying the total cost and labels
        Console.WriteLine($"Order 2 Total Cost ${order2.GetTotalPrice()}");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
    }
}