namespace MedicineInc.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public Boolean OrderDone { get; set; }
        public int? MedicineId { get; set; }
        public virtual Medicine? Medicine { get; set; }
        public List<Medicine>? OrderDetails { get; set; }
        public int BranchID { get; set; }
        public virtual Branch? Branch { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
