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
                    Feat = true,
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
                    Feat = true,
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
                    Feat = false,
                    Price = 7.49,
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
                    Feat = false, 
                    Price = 4.29,
                    ImageRef = "images/strepsils.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Medicine
                {
                    Id = 5,
                    MediName = "Tylenol",
                    Usage = "Pain reliever and fever reducer",
                    Feat = true,
                    Price = 9.99,
                    ImageRef = "images/tylenol.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Medicine
                {
                    Id = 6,
                    MediName = "Ibuprofen",
                    Usage = "Nonsteroidal anti-inflammatory drug (NSAID)",
                    Feat = true,
                    Price = 7.49,
                    ImageRef = "images/ibuprofen.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Medicine
                {
                    Id = 7,
                    MediName = "Claritin",
                    Usage = "Antihistamine for allergy relief",
                    Feat = false,
                    Price = 5.99,
                    ImageRef = "images/claritin.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
