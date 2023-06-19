using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Domain.Common;

namespace OnionArcCoreTemplate.Domain.Entities
{
	public class User : BaseEntity
	{
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

		public int? CartId { get; set; }
		public Cart Cart { get; set; }

		public List<Order> Orders { get; set; }
		public List<UserWishlist> Wishlist { get; set; }
	}

	public class UserWishlist
	{
		public int UserId { get; set; }
		public User User { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
