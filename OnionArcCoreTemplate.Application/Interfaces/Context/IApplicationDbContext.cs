using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionArcCoreTemplate.Domain.Entities;

namespace OnionArcCoreTemplate.Application.Interfaces.Context
{
	public interface IApplicationDbContext
	{
		DbSet<Product> Products { get; set; }
	}
}
