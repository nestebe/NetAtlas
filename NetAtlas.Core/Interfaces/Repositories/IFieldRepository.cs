using NetAtlas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Core.Interfaces.Repositories
{
    public interface IFieldRepository
    {

        public Task<Field> GetField(string id);
        public Task<List<Field>> GetFieldsByCollection(string collectionId);
        public Task<Field> SaveField(Field field);
        public Task<Field> DeleteField(string id);
    }
}
