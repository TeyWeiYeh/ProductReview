using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
    public class BrandsSeedConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Apple",
                    CategoryId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Brand
                {
                    Id = 2,
                    Name = "Samsung",
                    CategoryId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Brand
                {
                    Id = 3,
                    Name = "Dell",
                    CategoryId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Brand
                {
                    Id = 4,
                    Name = "HP",
                    CategoryId = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );   
        }
    }
}
