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
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("Users");

			// Primary key
			builder.HasKey(u => u.Id);

			// Username is unique
			builder.HasIndex(u => u.Username).IsUnique();

			// Email is unique
			builder.HasIndex(u => u.Email).IsUnique();

			// User-Order relationship
			builder.HasMany(u => u.Orders)
				.WithOne(o => o.User)
				.HasForeignKey(o => o.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			// User-Cart relationship
			builder.HasOne(u => u.Cart)
				.WithOne(c => c.User)
				.HasForeignKey<Cart>(c => c.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			// User-Wishlist relationship
			builder.HasMany(u => u.Wishlist)
				.WithMany(p => p.UsersWishlist)
				.UsingEntity<Dictionary<string, object>>(
					"UserWishlist",
					j => j.HasOne<Product>().WithMany().HasForeignKey("ProductId").OnDelete(DeleteBehavior.Cascade),
					j => j.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.Cascade),
					j =>
					{
						j.HasKey("UserId", "ProductId");
						j.ToTable("UserWishlist");
					}
				);

			// Other properties and configurations
			// ...

			// Ignore the Cart property in the database mapping
			builder.Ignore(u => u.Cart);
		}
	}
}
