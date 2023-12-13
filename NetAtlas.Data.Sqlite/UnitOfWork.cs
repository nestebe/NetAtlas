using NetAtlas.Core;
using NetAtlas.Core.Interfaces.Repositories;
using NetAtlas.Data.Sqlite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Data.Sqlite
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AtlasDatabase _context;
        private ICollectionRepository _collectionRepository;

        public UnitOfWork(AtlasDatabase context)
        {
            this._context = context;
        }

        public ICollectionRepository Collections => _collectionRepository ?? new CollectionRepository(_context);

        public IFieldRepository Fields => throw new NotImplementedException();

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
