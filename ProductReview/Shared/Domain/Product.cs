namespace ProductReview.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        //public int? CategoryId { get; set; }
        //public virtual Category? Category { get; set; }
        public int? BrandId { get; set; }
        public virtual Brand? Brand { get; set; }
        //for customer side
        public virtual List<Review>? Reviews { get; set; }
    }
}