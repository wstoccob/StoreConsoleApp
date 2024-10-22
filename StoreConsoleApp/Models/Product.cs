using System.Globalization;

namespace StoreConsoleApp.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    private decimal Price { get; set; }
    public int Stock { get; set; }

    public Product(int id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price.ToString("C2", CultureInfo.CurrentCulture)}, Stock: {Stock}";
    }
}