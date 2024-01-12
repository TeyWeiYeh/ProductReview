namespace ProductReview.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string? Image { get; set; } = String.Empty;
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
    }
}