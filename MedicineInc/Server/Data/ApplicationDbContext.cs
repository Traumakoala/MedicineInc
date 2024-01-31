using Duende.IdentityServer.EntityFramework.Options;
using MedicineInc.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MedicineInc.Shared.Domain;
using MedicineInc.Server.Configurations.Entities;

namespace MedicineInc.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Medicine> Medicines { get; set;}
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Branch> Branchs { get; set;}
        public DbSet<Cart> Carts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MedicineSeedConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerSeedConfiguration());
            modelBuilder.ApplyConfiguration(new BranchSeedConfiguration());
            modelBuilder.ApplyConfiguration(new OrderSeedConfiguration());
            modelBuilder.ApplyConfiguration(new StaffSeedConfiguration());
        }

    }
}