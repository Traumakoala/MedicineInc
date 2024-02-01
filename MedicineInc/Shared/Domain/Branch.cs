namespace MedicineInc.Shared.Domain
{
    public class Branch : BaseDomainModel
    {
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }
        public int ManagerID { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
