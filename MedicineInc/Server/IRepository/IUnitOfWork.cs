using MedicineInc.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineInc.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Medicine> Medicines { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Branch> Branches { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Cart> Carts { get; }
    }
}