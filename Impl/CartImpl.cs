using supermarket_management_system.Interfaces;
using static Program;


namespace supermarket_management_system.Impl
{
    internal class CartImpl : ICart
    {
        private readonly List<Product> Items;

        public CartImpl()
        {
            Items = new List<Product>();
        }

        public List<Product> GetItems()
        {
            return Items;
        }
        public void AddItem(Product product)
        {
            Items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            Items.Remove(product);
        }

        public void ClearCart()
        {
            Items.Clear();
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
