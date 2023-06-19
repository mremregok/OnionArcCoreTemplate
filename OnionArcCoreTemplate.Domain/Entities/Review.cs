using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Domain.Common;

namespace OnionArcCoreTemplate.Domain.Entities
{
	public class Review : BaseEntity
	{
		public string Content { get; set; }
		public int Rating { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int ShopId { get; set; }
		public Shop Shop { get; set; }
	}
}
