using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Interfaces
{
    internal interface ICustomer
    {
        public void AddToCart(Product product);
        public void RemoveFromCart(Product product);
        public void ViewCart();
        public void PayForItems(Customer customer, Employee employee, CashRegister cashRegister);
    }
}
