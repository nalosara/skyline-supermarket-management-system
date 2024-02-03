internal partial class Program
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public Product(string name, double price, int quantity, ProductCategory productCategory)
        {
            this.ProductCategory = productCategory;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}