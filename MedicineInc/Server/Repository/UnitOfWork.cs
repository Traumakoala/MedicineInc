using MedicineInc.Server.Data;
using MedicineInc.Server.IRepository;
using MedicineInc.Server.Models;
using MedicineInc.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedicineInc.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Medicine> _medicines;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<Branch> _branches;
        private IGenericRepository<Customer> _customers;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Medicine> Medicines
        => _medicines ??= new GenericRepository<Medicine>(_context);

        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);

        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);

        public IGenericRepository<Branch> Branches
            => _branches ??= new GenericRepository<Branch>(_context);

        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}