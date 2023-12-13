using NetAtlas.Core.Interfaces.Repositories;
using NetAtlas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Data.Sqlite.Repositories
{
    public class CollectionRepository : Repository<Collection>, ICollectionRepository
    {
        private AtlasDatabase AtlasDatabase
        {
            get { return Context as AtlasDatabase; }
        }

        public CollectionRepository(AtlasDatabase context)
            : base(context) { }
    }
}
