using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using OnionArcCoreTemplate.Application.Interfaces.Repositories;
using OnionArcCoreTemplate.Application.Interfaces.UnitOfWork;
using OnionArcCoreTemplate.Persistence.Context;

namespace OnionArcCoreTemplate.Persistence.UnitOfWorks
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		public IProductRepository ProductRepository { get; }
		public UnitOfWork(ApplicationDbContext context, IProductRepository productRepository)
		{
			_context = context;
			ProductRepository = productRepository;
		}
		public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();
		public async ValueTask DisposeAsync() { }

		public void Dispose()
		{
		}
	}
}
