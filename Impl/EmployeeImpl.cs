using supermarket_management_system.Interfaces;
using static Program;

namespace supermarket_management_system.Impl
{
    internal class EmployeeImpl : IEmployee
    {
        private readonly ICart CartI;
        private readonly IShelf ShelfI;

        public EmployeeImpl(ICart cart, IShelf shelf)
        {
            CartI = cart;
            ShelfI = shelf;
        }

        public void AddProductToShelf(Product product)
        {
            Console.WriteLine($"Adding product {product.Name} to shelf.");
            ShelfI.AddProduct(product);
        }

        public void RemoveProductFromShelf(Product product)
        {
            Console.WriteLine($"Removing product {product.Name} from shelf.");
            ShelfI.RemoveProduct(product);
        }

        public void ProcessPayment(Customer customer, double amount, CashRegister cashRegister)
        {
            Console.WriteLine($"Processing payment for customer {customer.Name}...");

            if (cashRegister.TotalCash >= amount)
            {
                cashRegister.TotalCash -= amount;
                Console.WriteLine("Payment processed successfully!");

                double change = 0;
                if (amount > CartI.GetTotal())
                {
                    change = amount - CartI.GetTotal();
                    Console.WriteLine($"Change given: ${change}");
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds in the cash register.");
            }
        }

        public void Checkout(Customer customer, Employee employee, CashRegister cashRegister)
        {
            Console.WriteLine($"Items in {customer.Name}'s cart:");

            foreach (var item in customer.Cart.Items)
            {
                Console.WriteLine($"{item.Name} - ${item.Price}");
            }

            double totalCost = CartI.GetTotal();
            Console.WriteLine($"Total: ${totalCost}");

            ProcessPayment(customer, totalCost, cashRegister);

            CartI.ClearCart();

            Console.WriteLine("Checkout completed.");
        }
    }
}
