namespace MedicineInc.Shared.Domain
{
    public class Customer : BaseDomainModel

    {
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set;}
        public string? CustomerPhone { get; set;}
        public string? CustomerUser { get; set;}
        public string? CustomerPassword { get; set;}
        public string? Gender { get; set;}
        public string? Allergies { get; set;}
        public string? CustomerAddress { get; set;}
    }
}
