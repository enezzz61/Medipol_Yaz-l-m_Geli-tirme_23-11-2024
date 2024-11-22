using System;
using System.Collections.Generic;

public class Cart
{
    public int CartID { get; set; }
    public Dictionary<Product, int> Items { get; set; }

    
    public Cart(int cartID)
    {
        CartID = cartID;
        Items = new Dictionary<Product, int>();
    }

    
    public void AddItem(Product product, int quantity)
    {
        Items[product] = quantity;
        Console.WriteLine($"{product.Name} added to cart.");
    }

    public void RemoveItem(Product product)
    {
        Items.Remove(product);
        Console.WriteLine($"{product.Name} removed from cart.");
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Key.Price * item.Value;
        }
        return total;
    }
}