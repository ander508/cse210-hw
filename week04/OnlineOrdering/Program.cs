using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
     // First order
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT123", 1000.0, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.0, 2));

        // Second order
        Address address2 = new Address("456Mcc Road", "Calabar", "CAL", "Nigeria");
        Customer customer2 = new Customer("Anderson Offor", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Camera", "CAM001", 500.0, 1));
        order2.AddProduct(new Product("Tripod", "TRP001", 75.0, 1));

        // Display order info
        DisplayOrder(order1);
        Console.WriteLine("-----------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
    
    
    }
}