using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Review : BaseDomainModel
    { 
        public string? Description { get; set; } 
        public int Value { get; set; }
        public int BatteryLife { get; set; }
        public int Performance { get; set; }
        public int UserFriendly { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        
    }
}
