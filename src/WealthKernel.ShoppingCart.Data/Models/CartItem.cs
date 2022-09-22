namespace WealthKernel.ShoppingCart.Data.Models
{
    public class CartItem
    {
        public string Id { get; }

        public string Name { get; }

        public CartItem(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
