using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcCoreTemplate.Application.Common.Enums
{
	public enum OrderStatus
	{
		Pending,     // Beklemede
		Shipped,     // Kargoda
		Delivered,   // Teslim Edildi
		Cancelled    // İptal Edildi
	}
}
