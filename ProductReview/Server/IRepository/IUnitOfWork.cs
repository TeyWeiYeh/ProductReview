using ProductReview.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReview.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Favourite> Favourites { get; }
        IGenericRepository<Link> Links { get; }
        IGenericRepository<News> News { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Brand> Brands { get; }
    }
}