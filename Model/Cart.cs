internal partial class Program
{
    public class Cart
    {
        public List<Product> Items { get; set; }

        public Cart()
        {
            Items = new List<Product>();
        }

    }
}