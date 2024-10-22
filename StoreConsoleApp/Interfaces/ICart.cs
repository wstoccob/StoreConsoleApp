namespace StoreConsoleApp.Interfaces;

public interface ICart
{
    public void RemoveProduct(int productId);
    public void ViewCart();
}