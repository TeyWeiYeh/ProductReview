﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductReview.Shared.Domain
{
    public class Review : BaseDomainModel
    {
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Description { get; set; }
		//public byte[]? Image { get; set; }
		public string? Image { get; set; }
		[Required]
		public int Value { get; set; }
		[Required]
		public int BatteryLife { get; set; }
		[Required]
		public int Performance { get; set; }
		[Required]
		public int UserFriendly { get; set; }
		
		public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
        
    }
}
