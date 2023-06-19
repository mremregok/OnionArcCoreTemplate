using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArcCoreTemplate.Domain.Entities;

namespace OnionArcCoreTemplate.Persistence.Configuration
{
	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.ToTable("Carts"); // Tablo adı
			builder.HasKey(p => p.Id); // Primary key

			builder.HasOne(p => p.User)
				.WithOne(c => c.Cart)
				.HasForeignKey<User>(p => p.Id)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasMany(c => c.CartItems)
				.WithOne(c => c.Cart)
				.HasForeignKey(c => c.CartId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
