using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        
        User user = new User(1, "John Doe", "john@example.com", "password123");

        
        Product product1 = new Product(101, "Laptop", 1500.00, 10, "High performance laptop");
        Product product2 = new Product(102, "Phone", 800.00, 15, "Latest model smartphone");

        
        Cart cart = new Cart(1);
        cart.AddItem(product1, 1);
        cart.AddItem(product2, 2);

        
        Order order = new Order(1, user, new List<Product> { product1, product2 });
        order.PlaceOrder();

        
        Console.WriteLine($"Total Amount: ${cart.CalculateTotal()}");
    }
}