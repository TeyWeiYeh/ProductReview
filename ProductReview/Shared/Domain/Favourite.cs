﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview.Shared.Domain
{
    public class Favourite : BaseDomainModel
    {
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
