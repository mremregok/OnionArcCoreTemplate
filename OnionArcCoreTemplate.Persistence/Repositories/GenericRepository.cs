using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Application.Common;
using OnionArcCoreTemplate.Application.Interfaces.Repositories;
using OnionArcCoreTemplate.Persistence.Context;

namespace OnionArcCoreTemplate.Persistence.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntityDTO, new()
	{
		private readonly ApplicationDbContext _context;
		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
		}
	}
}
