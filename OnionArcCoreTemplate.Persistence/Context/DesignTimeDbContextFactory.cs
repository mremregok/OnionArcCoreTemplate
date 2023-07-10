using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace OnionArcCoreTemplate.Persistence.Context
{
	public abstract class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
	{
		protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);
		public TContext CreateDbContext(string[] args)
		{
			DbContextOptionsBuilder<TContext> builder = new DbContextOptionsBuilder<TContext>();
			builder.UseSqlServer(args[0]);
			return CreateNewInstance(builder.Options);
		}
	}
}
