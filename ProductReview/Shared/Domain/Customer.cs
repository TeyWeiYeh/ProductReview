using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Favourite>? Favourites { get; set; }
    }
}
