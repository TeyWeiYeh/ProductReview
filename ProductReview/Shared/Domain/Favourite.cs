using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Favourite : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }  

        public int? BrandId { get; set; }
        public virtual Brand? Brand { get; set; }
    }
}
