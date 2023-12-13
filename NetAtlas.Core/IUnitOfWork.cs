using NetAtlas.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICollectionRepository Collections { get; }
        IFieldRepository Fields { get; }
        Task<int> CommitAsync();

    }
}
