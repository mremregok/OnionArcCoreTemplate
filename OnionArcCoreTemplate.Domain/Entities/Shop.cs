using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Domain.Common;

namespace OnionArcCoreTemplate.Domain.Entities
{
	public class Shop : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }

		public int OwnerId { get; set; }
		public User Owner { get; set; }

		public List<Product> Products { get; set; }
		public List<Review> Reviews { get; set; }
	}
}
