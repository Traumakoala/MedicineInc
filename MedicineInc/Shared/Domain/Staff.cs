
namespace MedicineInc.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffUser { get; set; }
        public string? StaffPassword { get; set; }
        public string? StaffAddress { get; set; }
        public Boolean IsManager { get; set; }
        public int? ManagerID { get; set; }
        public string? Gender { get; set; }
        public int BranchID { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
