using supermarket_management_system.Interfaces;

internal partial class Program
{
    public class Customer : Person
    {
        public Cart Cart { get; set; }

        public Customer()
        {
            Cart = new Cart();
        }

    }
}