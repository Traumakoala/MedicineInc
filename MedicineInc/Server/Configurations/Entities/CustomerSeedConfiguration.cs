using MedicineInc.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MedicineInc.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    CustomerName = "John Doe",
                    CustomerEmail = "john.doe@example.com",
                    CustomerPhone = "123-456-7890",
                    CustomerUser = "john_doe",
                    CustomerPassword = "hashed_password",
                    Gender = "Male",
                    Allergies = "None",
                    CustomerAddress = "123 Main St, City, Country",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
