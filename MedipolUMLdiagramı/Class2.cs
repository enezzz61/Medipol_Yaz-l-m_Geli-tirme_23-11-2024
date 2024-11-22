using System;
using System.Collections.Generic;

public class Order
{
    public int OrderID { get; set; }
    public DateTime Date { get; set; }
    public double TotalAmount { get; set; }
    public User User { get; set; }
    public List<Product> Products { get; set; }

    
    public Order(int orderID, User user, List<Product> products)
    {
        OrderID = orderID;
        Date = DateTime.Now;
        User = user;
        Products = products;
        TotalAmount = CalculateTotalAmount();
    }

    
    public void PlaceOrder()
    {
        Console.WriteLine($"Order placed for user: {User.Name}");
    }

    public void CancelOrder()
    {
        Console.WriteLine("Order canceled.");
    }

    public void TrackOrder()
    {
        Console.WriteLine("Order is being tracked.");
    }

    private double CalculateTotalAmount()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }
}