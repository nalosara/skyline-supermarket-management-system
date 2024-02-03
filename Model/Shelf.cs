using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal partial class Program
{
    internal class Shelf
    {
        public List<Product> Products { get; set; }

        public Shelf() {
            Products = new List<Product>
            {
                new Product("Apple", 2.99, 20, ProductCategory.Fruit),
                new Product("Banana", 1.99, 15, ProductCategory.Fruit),
                new Product("Pineapple", 2.99, 20, ProductCategory.Fruit),
                new Product("Steak", 15.99, 4, ProductCategory.Meat),
                new Product("Cookie", 0.99, 20, ProductCategory.Sweets),
                new Product("Salad", 1.99, 25, ProductCategory.Vegetables)
            };

        }

    }
}
