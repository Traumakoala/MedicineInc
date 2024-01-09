namespace MedicineInc.Server.Models
{
    public class CartService
    {
        private List<string> cartItems = new List<string>();

        public IReadOnlyList<string> CartItems => cartItems.AsReadOnly();

        public void AddToCart(string product)
        {
            cartItems.Add(product);
        }
    }

}
