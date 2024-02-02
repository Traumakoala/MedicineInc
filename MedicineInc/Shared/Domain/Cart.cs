namespace MedicineInc.Shared.Domain
{
    public class Cart : BaseDomainModel
    {
        public double? TotalAmount { get; set; }
        public int? MedicineId { get; set; }
        public virtual Medicine? Medicine { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
