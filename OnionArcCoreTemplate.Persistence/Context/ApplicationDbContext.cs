using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnionArcCoreTemplate.Application.Interfaces.Context;
using OnionArcCoreTemplate.Domain.Entities;

namespace OnionArcCoreTemplate.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

			base.OnModelCreating(builder);
		}
	}
}