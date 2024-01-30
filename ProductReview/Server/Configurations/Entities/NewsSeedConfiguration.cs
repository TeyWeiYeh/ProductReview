using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
    public class NewsSeedConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData(
                new News
                {
                    Id = 1,
                    Title = "Apple to skip 16 and jump to 17",
                    Description = "Apple has confirmed that they will not have iphone 16",
                    Image = "images/iphone13.jpg",
                    Content = "Apple has confirmed that they will not have iphone 16 and will jump to 17",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new News
                {
                    Id = 2,
                    Title = "Samsung Z fold 6 leaked",
                    Description = "Samsung's Z fold 6 design leaked",
                    Image = "https://www.digitaltrends.com/wp-content/uploads/2022/08/samsung-galaxy-z-fold-4-hands-on-23.jpg?resize=3000%2C2000&p=1",
                    Content = "Samsung's Z fold 6 design leaked and it looks amazing",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        } 
    }
}
