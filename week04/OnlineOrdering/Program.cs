using System;

class Program
{
    static void Main()
    {
        // Address for customer 1 (USA)
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 1000.00, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.00, 2));

        // Address for customer 2 (International)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P2001", 45.00, 1));
        order2.AddProduct(new Product("Monitor", "P2002", 200.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "P2003", 10.00, 3));

        // Show details for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Show details for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
