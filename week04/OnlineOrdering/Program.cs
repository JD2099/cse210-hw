using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Laptop", "P100", 800, 1));

        order1.AddProduct(
            new Product("Mouse", "P101", 25, 2));

        order1.AddProduct(
            new Product("Keyboard", "P102", 50, 1));



        Address address2 = new Address(
            "456 Avenida Central",
            "Lima",
            "Lima",
            "Peru");

        Customer customer2 = new Customer(
            "Carlos Perez",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Monitor", "P200", 250, 2));

        order2.AddProduct(
            new Product("Headphones", "P201", 75, 1));



        Console.WriteLine("===== ORDER 1 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.GetTotalCost()}");



        Console.WriteLine("\n==============================");



        Console.WriteLine("\n===== ORDER 2 =====");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.GetTotalCost()}");
    }
}