using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Interfaces
{
    internal interface ICart
    {
        public List<Product> GetItems();
        public void AddItem(Product product);
        public void RemoveItem(Product product);
        public void ClearCart();
        public double GetTotal();

    }
}
