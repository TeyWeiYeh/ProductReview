using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
    public class ProductsSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Iphone SE",
                    Description = "Iphone SE...",
                    BrandId = null,
                    CategoryId = null,
                    Image = "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_announce-iphone13pro_09142021_big.jpg.large.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Product
                {
                    Id = 2,
                    Name = "Iphone 13 ",
                    Description = "Iphone 13",
					BrandId = null,
					CategoryId = null,
					Image = "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_announce-iphone13pro_09142021_big.jpg.large.jpg",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            ) ;
        }
    }
}
