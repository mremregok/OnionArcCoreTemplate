using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArcCoreTemplate.Domain.Entities;
using OnionArcCoreTemplate.Persistence.Context;

namespace OnionArcCoreTemplate.Persistence.Seeds
{
	public static class SeedData
	{
		public static void Seed(IServiceProvider app)
		{
			var scope = app.CreateScope();
			var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
			context.Database.Migrate();
			if (!context.Products.Any())
			{
				Product product = new Product()
				{
					Name = "Test",
					Description = "Test",
					Price = 1,
					Image = "",
					Stock = 1,
					Rating = 9.99M
				};

				context.Products.Add(product);

				context.SaveChanges();
			}
		}
	}
}
