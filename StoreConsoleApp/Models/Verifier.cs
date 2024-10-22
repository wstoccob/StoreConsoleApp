using StoreConsoleApp.Interfaces;

namespace StoreConsoleApp.Models;

public class Verifier : IVerifier
{
    private readonly string[] acceptableMenuChoices = new string[] { "1", "2", "3", "4", "5" };
    private const string WrongMenuChoiceMessage = "It seems you chose a wrong option. Try one more time!";
    private const string WrongAddingChoiceMessage = "It seems you chose a wrong product or the product is out of stock. " +
                                                    "Try one more time!";
    private const string WrongRemovingChoiceMessage = "It seems you chose a wrong product from your cart. Try one more time!";

    public void VerifyMenuChoice(string? choice)
    {
        if (!acceptableMenuChoices.Contains(choice))
        {
            throw new ArgumentOutOfRangeException(nameof(choice), WrongMenuChoiceMessage);
        }
    }

    public void VerifyAddingChoice(List<Product> listOfProducts, string? addingChoice)
    {
        var IdsAndStock = listOfProducts
            .Select(e => 
                new KeyValuePair<string, int>(e.Id.ToString(), e.Stock))
            .ToDictionary(e => e.Key, e => e.Value);
        if (!IdsAndStock.ContainsKey(addingChoice) || IdsAndStock[addingChoice] <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(addingChoice), WrongAddingChoiceMessage);
        }
    }

    public void VerifyRemovingChoice(List<Product> listOfProducts, string? removingChoice)
    {
        var listOfIds = listOfProducts
            .Select(e => e.Id.ToString()).ToArray();
        if (!listOfIds.Contains(removingChoice))
        {
            throw new ArgumentOutOfRangeException(nameof(removingChoice), WrongRemovingChoiceMessage);
        }
    }
}