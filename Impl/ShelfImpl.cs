using supermarket_management_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace supermarket_management_system.Impl
{
    internal class ShelfImpl : IShelf
    {
        private readonly Shelf Shelf;

        public ShelfImpl(Shelf shelf)
        {
            this.Shelf = shelf;
        }

        public void AddProduct(Product product)
        {
            Shelf.Products.Add(product);
        }

        public void RemoveProduct(Product product) 
        {  
            Shelf.Products.Remove(product); 
        }
    }
}
