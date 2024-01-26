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
