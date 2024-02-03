using supermarket_management_system.Impl;

internal partial class Program
{
    private static void Main(string[] args)
    {
        double initialValue = 678.90;
        var cart = new CartImpl();
        var shelf = new Shelf();
        var shelfImpl = new ShelfImpl(shelf);
        var cashRegister = new CashRegisterImpl(new CashRegister(initialValue));
        var employee = new EmployeeImpl(cart, shelfImpl);
        var customer = new CustomerImpl(cart, employee);

        Console.WriteLine($"Adding products to cart: {shelf.Products[0].Name} and {shelf.Products[1].Name}.");
        customer.AddToCart(shelf.Products[0]);
        customer.AddToCart(shelf.Products[1]);

        Console.WriteLine("-------------------------");
        customer.ViewCart();

        Console.WriteLine("-------------------------");
        customer.PayForItems(new Customer(), new Employee(), new CashRegister(initialValue));

        Console.WriteLine("Shelf contents after purchase:");
        foreach (var product in shelf.Products)
        {
            Console.WriteLine($"{product.Name} - ${product.Price}");
        }
    }
}