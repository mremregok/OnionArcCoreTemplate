using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcCoreTemplate.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable, IDisposable
    {
    }
}
