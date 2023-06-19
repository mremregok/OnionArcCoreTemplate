using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnionArcCoreTemplate.Domain.Entities;

namespace OnionArcCoreTemplate.Persistence.Configuration
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("Products"); // Tablo adı
			builder.HasKey(p => p.Id); // Primary key
			builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
			builder.Property(p => p.Description).HasMaxLength(500);
			builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
			builder.Property(p => p.Image);
			builder.Property(p => p.Stock).IsRequired();
			builder.Property(p => p.Rating).HasColumnType("decimal(3,2)");

			builder.HasOne(p => p.Shop)
				.WithMany(s => s.Products)
				.HasForeignKey(p => p.ShopId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryId)
				.OnDelete(DeleteBehavior.SetNull);

			builder.HasMany(p => p.Reviews)
				.WithOne(r => r.Product)
				.HasForeignKey(r => r.ProductId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
