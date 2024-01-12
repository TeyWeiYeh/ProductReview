using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Link : BaseDomainModel
    {
        public string? PlatformName { get; set; } = String.Empty;
        public string? LinkUrl { get; set; } = String.Empty;
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
