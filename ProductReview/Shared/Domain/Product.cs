using System.ComponentModel.DataAnnotations;

namespace ProductReview.Shared.Domain
{
    public class Product : BaseDomainModel
    {
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Description { get; set; }
        public string? Image { get; set; }
		
		public int? BrandId { get; set; }
        public virtual Brand? Brand { get; set; }
		
		public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual List<Review>? Reviews { get; set; }
		
	}
}