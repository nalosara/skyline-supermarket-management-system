
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Interfaces
{
    internal interface IEmployee
    {
        public void AddProductToShelf(Product product);
        public void RemoveProductFromShelf(Product product);
        public void ProcessPayment(Customer customer, double amount, CashRegister cashRegister);
        public void Checkout(Customer customer, Employee employee, CashRegister cashRegister);
    }
}
