using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Brand : BaseDomainModel
    {
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
