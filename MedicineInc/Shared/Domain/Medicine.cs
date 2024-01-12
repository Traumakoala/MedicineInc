namespace MedicineInc.Shared.Domain
{
    public class CartService
    {
        private List<Medicine> cartItems = new List<Medicine>();

        public IReadOnlyList<Medicine> CartItems => cartItems.AsReadOnly();

        public void AddToCart(Medicine medicine)
        {
            cartItems.Add(medicine);
        }

    }
    public class Medicine : BaseDomainModel
    {
        public string? MediName { get; set; }
        public string? Usage { get; set; }
        public int Count { get; set; } = 1;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? Manufacturer { get; set; }
        public Boolean Controlled { get; set; }
        public string? Ingredient { get; set; }
        public string? Dosage { get; set; }
        public int? OrderID { get; set; }
        public virtual Order? Order { get; set; }

    }

}



   