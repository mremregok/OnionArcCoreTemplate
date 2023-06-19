using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Domain.Common;

namespace OnionArcCoreTemplate.Domain.Entities
{
	public class CartItem : BaseEntity
	{
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal TotalPrice { get; set; }

		public Product Product { get; set; }

		public int CartId { get; set; }
		public Cart Cart { get; set; }
	}

	public class Cart : BaseEntity
	{
		public int UserId { get; set; }
		public User User { get; set; }

		public List<CartItem> CartItems { get; set; }
	}
}
