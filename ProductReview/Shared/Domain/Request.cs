﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Request : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Value { get; set; }
        public int BatteryLife { get; set; }
        public int Performance { get; set; }
        public int UserFriendly { get; set; }
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public bool IsAccepted { get; set; }

        // Foreign key for Review
        public int? ReviewId { get; set; }

        // Navigation property
        public virtual Review? Review { get; set; }
    }
}