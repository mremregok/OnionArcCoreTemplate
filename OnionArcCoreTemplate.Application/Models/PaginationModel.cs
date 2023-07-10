using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcCoreTemplate.Application.Models
{
	public class PaginationModel
	{
		public int PageSize { get; set; }
		public int PageNumber { get; set; }
        public PaginationModel(int pageSize, int pageNumber)
        {
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }
    }
}
