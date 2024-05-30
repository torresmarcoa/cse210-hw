using System; 

public class Customer
{
    // Member variables for the customer (name and address)
    private Address _address;
    private string _name; 

    // Constructor to initialize the Customer object
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to determine if the user is in USA or not
    public bool IsCustomerInUSA()
    {
        return _address.IsAddressInUSA();
    }

    // Getter methods for accessing private member variables
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddressString();
    }

}