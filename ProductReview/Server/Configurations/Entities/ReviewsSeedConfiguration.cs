using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
    public class ReviewsSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,
                    Title = "Iphone SE review",
                    Description = "Iphone SE is so ass",
                    Value = 1,
                    BatteryLife = 1,
                    Performance = 1,
                    UserFriendly = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    ProductId = null,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Review
                {
                    Id = 2,
                    Title = "Iphone 13 review",
                    Description = "Iphone 13 has the best value in 2024",
                    Value = 5,
                    BatteryLife = 5,
                    Performance = 5,
                    UserFriendly = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    ProductId = null,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            ); 
        }
    }
}
