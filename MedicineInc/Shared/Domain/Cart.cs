using System.ComponentModel.DataAnnotations.Schema;

namespace MedicineInc.Shared.Domain
{
    public class Cart : BaseDomainModel
    {
        public double TotalAmount { get; set; }
        [NotMapped]
        public List<int>? MedicineId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
