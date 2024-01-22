namespace MedicineInc.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public string? MediName { get; set; }
        public double Price { get; set; }
        public Boolean? feat { get; set; }
        public int Count { get; set; }
        public string? Usage { get; set; }
        public string? ImageRef { get; set; }
        public Boolean OrderDone { get; set; }
        public int BranchID { get; set; }
        public virtual Branch? Branch { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
