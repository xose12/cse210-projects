using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses (Updated to Ghana, Accra)
        Address address1 = new Address("123 Main St", "Accra", "Greater Accra", "Ghana");
        Address address2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating products
        Product product1 = new Product("Laptop", 101, 800.00, 2);
        Product product2 = new Product("Headphones", 102, 150.00, 1);
        Product product3 = new Product("Smartphone", 103, 600.00, 1);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Displaying results for order 1
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice():F2}\n");

        // Displaying results for order 2
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice():F2}");
    }
}
