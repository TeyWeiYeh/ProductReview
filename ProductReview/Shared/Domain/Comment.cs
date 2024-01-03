using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Comment : BaseDomainModel
    {
        public string? Description { get; set; } = String.Empty;
        public int ReviewId { get; set; }
        public virtual Review? Review { get; set; }

    }
}
