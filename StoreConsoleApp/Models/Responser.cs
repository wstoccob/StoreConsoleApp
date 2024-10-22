using StoreConsoleApp.Interfaces;

namespace StoreConsoleApp.Models;

public class Responser : IResponser
{
    private string menuChoice = "\nThe main meny: " +
                                      "\n1. To see the list of products" +
                                      "\n2. To add a product to cart" +
                                      "\n3. To remove a product from cart" +
                                      "\n4. To see the cart" +
                                      "\n5. Exit" +
                                      "\nChoose an option: ";

    private string addingResponse = "\nChoose which product you would like to add to cart by entering its Id: ";
    private string removingResponse = "\nChoose which product you would like to remove from the cart by entering its Id: ";
    public string? ShowMenu()
    {
        Console.WriteLine(menuChoice);
        return Console.ReadLine();
    }

    public string? AddingProductToCartResponse()
    {
        Console.WriteLine(addingResponse);
        return Console.ReadLine();
    }

    public string? RemovingProductFromCartResponse()
    {
        
        Console.WriteLine(removingResponse);
        return Console.ReadLine();
    }
}