using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Shared.Domain;

namespace ProductReview.Server.Configurations.Entities
{
    public class LinksSeedConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasData(
                new Link
                {
                    Id = 1,
                    PlatformName = "Amazon",
                    LinkUrl = "https://www.amazon.com/New-Simple-Mobile-Prepaid-Product/dp/B0875RK26R/ref=sr_1_1?keywords=iPhone+SE&qid=1704944545&sr=8-1",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Link
                {
                    Id = 2,
                    PlatformName = "Apple",
                    LinkUrl = "https://www.apple.com/iphone-se/",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
