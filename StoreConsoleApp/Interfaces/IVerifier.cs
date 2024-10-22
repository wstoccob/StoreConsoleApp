using StoreConsoleApp.Models;

namespace StoreConsoleApp.Interfaces;

public interface IVerifier
{
    public void VerifyMenuChoice(string? choice);
    public void VerifyAddingChoice(List<Product> listOfProducts, string? addingChoice);
    public void VerifyRemovingChoice(List<Product> listOfProducts, string? removingChoice);
}