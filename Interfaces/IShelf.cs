using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Interfaces
{
    internal interface IShelf
    {
        public void AddProduct(Product product);
        public void RemoveProduct(Product product);

    }
}
