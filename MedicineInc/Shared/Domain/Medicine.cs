namespace MedicineInc.Shared.Domain
{
    
    public class Medicine : BaseDomainModel
    {
        public string? MediName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string? Usage { get; set; }
        public string? ImageRef { get; set; }
    }

}



   