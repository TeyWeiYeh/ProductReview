using ProductReview.Server.Data;
using ProductReview.Server.IRepository;
using ProductReview.Server.Models;
using ProductReview.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProductReview.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<Category> _categories;
        private IGenericRepository<Product> _products;
        private IGenericRepository<Comment> _comments;
        private IGenericRepository<Favourite> _favourite;
        private IGenericRepository<Link> _links;
        private IGenericRepository<News> _news;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Brand> _brands;
        private IGenericRepository<Favourite> _favourites;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);

        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);

        public IGenericRepository<Link> Links => _links ??= new GenericRepository<Link>(_context);

        public IGenericRepository<News> News => _news ??= new GenericRepository<News>(_context);

        public IGenericRepository<Review> Reviews => _reviews ??= new GenericRepository<Review>(_context);

        public IGenericRepository<Staff> Staffs => _staffs ??= new GenericRepository<Staff>(_context);

        public IGenericRepository<Product> Products => _products ??= new GenericRepository<Product>(_context);

        public IGenericRepository<Comment> Comments => _comments ??= new GenericRepository<Comment>(_context);

        public IGenericRepository<Favourite> Favourites => _favourite ??= new GenericRepository<Favourite>(_context);

        public IGenericRepository<Brand> Brands => _brands ??= new GenericRepository<Brand>(_context);


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