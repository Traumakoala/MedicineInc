using MedicineInc.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MedicineInc.Server.Configurations.Entities
{
    public class MedicineSeedConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.HasData(
                new Medicine
                {
                    Id = 1,
                    MediName = "Glucosamine",
                    Usage = "Best Vitamins to stay healthy",
                    Price = 10.99,
                    ImageRef = "images/Glucosamine.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Medicine
                {
                    Id = 2,
                    MediName = "Panadol",
                    Usage = "Most Popular Item for Cold and Fever",
                    Price = 5.99,
                    ImageRef = "images/panadol.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Medicine
                {
                    Id = 3,
                    MediName = "Bandaids",
                    Usage = "For any and all injuries",
                    Price = 7.50,
                    ImageRef = "images/bandaids.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Medicine
                {
                    Id = 4,
                    MediName = "Strepsils",
                    Usage = "To soothe your sore throat",
                    Price = 4.25,
                    ImageRef = "images/strepsils.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
