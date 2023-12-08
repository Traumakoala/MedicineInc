namespace MedicineInc.Shared.Domain
{
    public class Medicine : BaseDomainModel
    {
        public string? MediName { get; set; }
        public string? Usage { get; set; } 
        public int Count { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? Manufacturer { get; set; }
        public Boolean Controlled { get; set; }
        public string? Ingredient { get; set; }
        public string? Dosage { get; set; }
        public int? OrderID { get; set; }
        public virtual Order? Order { get; set; }

    }
}
