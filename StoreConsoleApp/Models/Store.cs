namespace StoreConsoleApp.Models;

public class Store
{
    public List<Product> Products { get; set; }

    public Store()
    {
        Products = new List<Product>
        {
            new Product(1, "Laptop", 150000, 10),
            new Product(2, "Phone", 80000, 27),
            new Product(3, "Teddy Bear", 100, 52)
        };
    }

    public void ViewProducts()
    {
        Console.WriteLine("The list of products:");
        foreach (var product in Products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public Product GetProductById(int id)
    {
        return Products.FirstOrDefault(p => p.Id == id);
    }
}