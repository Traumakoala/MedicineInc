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
                    CartItems = new List<Medicine>
                    {
                        new Medicine
                        {
                            Id = 1,
                            MediName = "Glucosamine",
                            Usage = "Best Vitamins to stay healthy",
                            feat = true,
                            Price = 10.99,
                            ImageRef = "images/Glucosamine.jpg",
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now,
                            CreatedBy = "System",
                            UpdatedBy = "System"
                        }
                    },
                    CustomerId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
