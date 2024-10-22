using StoreConsoleApp.Models;

namespace StoreConsoleApp.Interfaces;

public interface IStore
{
    public Product GetProductById(int id);
    public void ViewProducts();
}