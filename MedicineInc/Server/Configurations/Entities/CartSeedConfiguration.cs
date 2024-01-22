using MedicineInc.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MedicineInc.Server.Configurations.Entities
{
    public class CartSeedConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasData(
                new Cart
                {
                    Id = 1,
                    CartItems = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
