using StoreConsoleApp.Models;

public class Program
{
    private static Store _store = new Store();
    private static Cart _cart = new Cart();
    private static Verifier _verifier = new Verifier();
    private static Responser _responser = new Responser();

    public static void Main(string[] args)
    {
        while (true)
        {
            string choice = _responser.ShowMenu();
            _verifier.VerifyMenuChoice(choice);
            
            switch (choice)
            {
                case "1":
                    _store.ViewProducts();
                    continue;
                case "2":
                    _store.ViewProducts();
                    var addingChoice = _responser.AddingProductToCartResponse();
                    _verifier.VerifyAddingChoice(_store.Products, addingChoice);
                    if (int.TryParse(addingChoice, out int addingProductId))
                    {
                        _cart.AddProduct(_store.GetProductById(addingProductId));
                    }
                    else
                    {
                        throw new InvalidOperationException("Could not parse the adding choice to integer");
                    }
                    continue;
                case "3":
                    _store.ViewProducts();
                    var removingChoice = _responser.RemovingProductFromCartResponse();
                    _verifier.VerifyRemovingChoice(_cart.Products, removingChoice);
                    if (int.TryParse(removingChoice, out int removingProductId))
                    {
                        _cart.RemoveProduct(removingProductId);
                    }
                    else
                    {
                        throw new InvalidOperationException("Could not parse the adding choice to integer");
                    }
                    continue;
                case "4":
                    _cart.ViewCart();
                    continue;
                case "5":
                    break;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
            }
        }
    }
}


