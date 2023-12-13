using NetAtlas.Core.Models;
using SQLite;

namespace NetAtlas.Data.Sqlite
{
    public class AtlasDatabase
    {
        public SQLiteAsyncConnection Database { get; set; }

        public AtlasDatabase()
        {
 
        }

        public async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Collection>();
        }


    }
}
