using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductReview.Server.Configurations.Entities;
using ProductReview.Server.Models;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<News>  News { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategoriesSeedConfiguration());
            builder.ApplyConfiguration(new CommentsSeedConfiguration());
            builder.ApplyConfiguration(new ProductsSeedConfiguration());
            builder.ApplyConfiguration(new ReviewsSeedConfiguration());
            builder.ApplyConfiguration(new LinksSeedConfiguration());
            builder.ApplyConfiguration(new NewsSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new BrandsSeedConfiguration());
        }

        public DbSet<ProductReview.Shared.Domain.Brand> Brand { get; set; } = default!;
    }
}