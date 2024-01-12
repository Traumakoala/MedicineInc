namespace MedicineInc.Client.Class
{
    public class CartService
    {
        private List<Product> cartItems = new List<Product>();

        public IReadOnlyList<Product> CartItems => cartItems.AsReadOnly();

        public void AddToCart(Product product)
        {
            cartItems.Add(product);
        }
       
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; } = 1;
    }

}
