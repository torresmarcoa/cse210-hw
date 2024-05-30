using System;
using System.Numerics;

public class Order
{
    // Member variables that gather the necessary information for an order
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor to initialize the order object
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price of the order
    public double GetTotalPrice()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }

        if (_customer.IsCustomerInUSA() == true)
        {
            totalCost += 5;
        }

        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    // Method to display the Packing Label for the order
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine("-------------------");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()} - {product.GetName()} / Quantity {product.GetQuantity()}");
        }
        Console.WriteLine();
    }

    // Method to display the shipping label for the order
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("-------------------");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
        Console.WriteLine();
    }
}