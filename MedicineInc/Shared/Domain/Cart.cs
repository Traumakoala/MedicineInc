namespace MedicineInc.Shared.Domain
{
    public class Cart : BaseDomainModel
    {
        public virtual List<Medicine>? CartItems { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
