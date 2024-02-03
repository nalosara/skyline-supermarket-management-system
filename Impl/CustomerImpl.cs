using supermarket_management_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Impl
{
    internal class CustomerImpl : ICustomer
    {
        private readonly ICart CartI;
        private readonly IEmployee EmployeeI;

        public CustomerImpl(ICart cart, IEmployee employee)
        {
            CartI = cart;
            EmployeeI = employee;
        }

        public void AddToCart(Product product)
        {
            CartI.AddItem(product);
            Console.WriteLine($"{product.Name} added to cart");
        }

        public void RemoveFromCart(Product product)
        {
            CartI.RemoveItem(product);
        }

        public void ViewCart()
        {
            Console.WriteLine("Items in your cart:");
            foreach (var item in CartI.GetItems())
            {
                Console.WriteLine($"{item.Name} - ${item.Price}");
            }
            Console.WriteLine($"Total: ${CartI.GetTotal()}");
        }

        public void PayForItems(Customer customer, Employee employee, CashRegister cashRegister)
        {
            double totalAmount = CartI.GetTotal();
            EmployeeI.ProcessPayment(customer, totalAmount, cashRegister);
            Console.WriteLine($"Payment processed successfully. Total amount paid: ${totalAmount}");
            CartI.ClearCart();
        }
    }
}
