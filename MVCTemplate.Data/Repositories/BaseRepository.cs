using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace MVCTemplate.Data.Repositories
{
    public abstract class BaseRepository<T>
    {
        //petapoco overload of db
        private readonly Database _db;
        public BaseRepository()
        {
            //defaults to instantiating with the first connection string in the webconfig
            _db = new Database();
        }

        public T Get(int id)
        {
            return _db.SingleOrDefault<T>(id);
        }

        public int Insert (T obj)
        {
            return (int)_db.Insert(obj);
        }

        public int Insert(string tableName, T obj)
        {
            return (int)_db.Insert(tableName, obj);
        }

        public int Insert(string tableName, string primaryKeyName, T obj)
        {
            return (int)_db.Insert(tableName, primaryKeyName, obj);
        }

        public int Update(T obj)
        {
            return _db.Update(obj);
        }

        public int Update(T obj, int primaryKeyValue)
        {
            return _db.Update(obj, primaryKeyValue);
        }

        public int Update(T obj, string primaryKeyName, IEnumerable<string> columns)
        {
            return _db.Update(obj, primaryKeyName, columns);
        }
    }
}
