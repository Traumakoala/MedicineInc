using MedicineInc.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MedicineInc.Server.Configurations.Entities
{
    public class BranchSeedConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch
                {
                    Id = 1,
                    BranchName = "MedicineInc",
                    BranchAddress = "311 New Upper Changi Road, #B2 - 12/13, Bedok Mall, 467360",
                    ManagerID = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
