using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Domain.Common;

namespace OnionArcCoreTemplate.Domain.Entities
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Image { get; set; }
		public int Stock { get; set; }
		public decimal Rating { get; set; }

		public int? ShopId { get; set; }
		public Shop Shop { get; set; }

		public int? CategoryId { get; set; }
		public Category Category { get; set; }

		public List<Review> Reviews { get; set; }
	}
}
