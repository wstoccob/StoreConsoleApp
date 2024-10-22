using StoreConsoleApp.Interfaces;

namespace StoreConsoleApp.Models;

public class Cart : ICart
{
    public List<Product> Products { get; set; }

    public Cart()
    {
        Products = new List<Product>() { };
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine($"{product.Name} is added to cart.");
    }

    public void RemoveProduct(int productId)
    {
        Product product = Products.FirstOrDefault(p => p.Id == productId);
        Products.Remove(product!);
        Console.WriteLine($"{product!.Name} is removed from cart.");
    }

    public void ViewCart()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("The cart is empty(.");
        }
        else
        {
            Console.WriteLine("Your cart contains:");
            foreach (var product in Products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
