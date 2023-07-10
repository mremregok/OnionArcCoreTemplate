using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Application.Dto;
using OnionArcCoreTemplate.Application.Interfaces.Repositories;
using OnionArcCoreTemplate.Persistence.Context;

namespace OnionArcCoreTemplate.Persistence.Repositories
{
	public class ProductRepository : GenericRepository<ProductDTO>, IProductRepository 
	{
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
