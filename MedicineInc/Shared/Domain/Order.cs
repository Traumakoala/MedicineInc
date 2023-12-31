﻿namespace MedicineInc.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public string? OrderDetails { get; set; }
        public Boolean OrderDone { get; set; }
        public Boolean OrderFinal { get; set; }
        public int BranchID { get; set; }
        public virtual Branch? Branch { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }  
    }
}
