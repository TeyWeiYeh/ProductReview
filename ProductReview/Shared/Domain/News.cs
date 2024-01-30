using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class News : BaseDomainModel
    {
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Description { get; set; }
		
		public string? Image { get; set; }
        public string? Content { get; set; }
		
		public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

    }
}
