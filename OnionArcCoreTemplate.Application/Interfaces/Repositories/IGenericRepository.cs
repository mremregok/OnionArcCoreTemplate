using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArcCoreTemplate.Application.Common;

namespace OnionArcCoreTemplate.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntityDTO, new()
    {
    }
}
