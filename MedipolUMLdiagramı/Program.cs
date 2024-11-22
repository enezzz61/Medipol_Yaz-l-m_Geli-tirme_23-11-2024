public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    
    public User(int userID, string name, string email, string password)
    {
        UserID = userID;
        Name = name;
        Email = email;
        Password = password;
    }

    
    public void Login()
    {
        Console.WriteLine($"{Name} logged in.");
    }

    public void Register()
    {
        Console.WriteLine($"{Name} registered.");
    }

    public void UpdateProfile()
    {
        Console.WriteLine($"{Name} updated profile.");
    }
}

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }

    
    public Product(int productID, string name, double price, int stock, string description)
    {
        ProductID = productID;
        Name = name;
        Price = price;
        Stock = stock;
        Description = description;
    }

    
    public void AddProduct()
    {
        Console.WriteLine($"{Name} added.");
    }

    public void UpdateProduct()
    {
        Console.WriteLine($"{Name} updated.");
    }

    public void DeleteProduct()
    {
        Console.WriteLine($"{Name} deleted.");
    }
}






