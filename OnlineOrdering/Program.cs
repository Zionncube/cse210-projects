using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("USB Cable", "A1", 5.99, 2));
        order1.AddProduct(new Product("Mouse", "B2", 12.99, 1));

        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "C3", 3.50, 4));
        order2.AddProduct(new Product("Pen", "D4", 1.25, 3));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
        }
    }
}