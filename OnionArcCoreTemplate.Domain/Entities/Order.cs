using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Application.Common.Enums;
using OnionArcCoreTemplate.Domain.Common;

namespace OnionArcCoreTemplate.Domain.Entities
{
	public class Order : BaseEntity
	{
		public decimal TotalPrice { get; set; }
		public string Status { get; set; }
		public string PaymentMethod { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public List<Product> Products { get; set; }
	}
}
