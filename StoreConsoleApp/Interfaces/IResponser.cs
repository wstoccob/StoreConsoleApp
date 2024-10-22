namespace StoreConsoleApp.Interfaces;

public interface IResponser
{
    public string? ShowMenu();
    public string? AddingProductToCartResponse();
    public string? RemovingProductFromCartResponse();
}