using System;

public class Product
{
    // Member variables to create a product
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    // Constructor to initialize the product
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id; 
        _price = price; 
        _quantity = quantity;
    }

    // Method to calculate the cost 
    public double CalculateCost()
    {
        return _price * _quantity;
    }

    // Getters methods for accessing private members variables
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
    
}